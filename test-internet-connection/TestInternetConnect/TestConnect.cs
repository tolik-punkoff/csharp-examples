using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Timers;
using System.IO;

namespace TestInternetConnect
{
    public class TestConnect
    {
        public delegate void OnConnecting(object sender);
        public delegate void OnConnectionOK(object sender);
        public delegate void OnRequestError(object sender);
        public delegate void OnProtocolError(object sender);
        public delegate void OnNetworkError(object sender);
        public delegate void OnPauseStart(object sender);
        public delegate void OnPauseEnd(object sender);
        public event OnConnecting Connecting;
        public event OnConnectionOK ConnectionOK;
        public event OnRequestError RequestError;
        public event OnProtocolError ProtocolError;
        public event OnNetworkError NetworkError;
        public event OnPauseStart PauseStart;
        public event OnPauseEnd PauseEnd;
        
        private HttpWebRequest request = null;
        private WebProxy proxy = null;
        private Timer InternalTimer = null;
        private System.Threading.Thread wthread = null;
        private bool Stopped = false;

        public int PauseTime { get; set; }
        public string URL { get; set; }

        public NetConnectionType ConnectionType { get; set; }
        public string ProxyAddress { get; set; }
        public int ProxyPort { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPassword { get; set; }        
        public int ConnectionTimeout { get; set; }

        public string ErrorMessage { get; private set; }

        public TestConnect(string url)
        {
            URL = url;
            InternalTimer = new Timer();
            InternalTimer.AutoReset = false;
            InternalTimer.Elapsed += new ElapsedEventHandler(InternalTimer_Elapsed);
        }

        void InternalTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Stopped) return;

            if (PauseEnd != null) PauseEnd(this);
            InternalTimer.Stop();
            Request();
        }

        public void Request()
        {
            if (Stopped) return;

            //устанавливаем параметры таймера паузы            
            if (PauseTime > 0)
            {
                InternalTimer.Interval = PauseTime * 1000;
            }

            //устанавливаем минимальные параметры для запроса
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(URL);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                if (RequestError != null) RequestError(this);
                return;
            }

            switch (ConnectionType)
            {
                case NetConnectionType.NoProxy:
                    {
                        proxy = null;
                        HttpWebRequest.DefaultWebProxy = null;
                        request.Proxy = proxy;
                    }; break;

                case NetConnectionType.SystemProxy:
                    {
                        HttpWebRequest.DefaultWebProxy = HttpWebRequest.GetSystemWebProxy();
                        proxy = null;
                    }; break;
                case NetConnectionType.ManualProxy:
                    {
                        proxy = new WebProxy(ProxyAddress, ProxyPort);
                        if (!string.IsNullOrEmpty(ProxyUser)) //есть имя пользователя, надобно авторизоваться
                        {
                            CredentialCache cred = new CredentialCache();
                            cred.Add(ProxyAddress, ProxyPort, "Basic",
                                new NetworkCredential(ProxyUser, ProxyPassword));

                            proxy.Credentials = cred;
                        }

                        request.Proxy = proxy;
                    }; break;
            }

            
            if (ConnectionTimeout > 0) request.Timeout = ConnectionTimeout;

            if (Connecting != null) Connecting(this);

            //получаем ответ
            HttpWebResponse resp = null;

            try
            {
                resp = (HttpWebResponse)request.GetResponse();
                //не вывалились в ошибку, значит все OK

                Stream temp = resp.GetResponseStream(); //если не прочитать поток ответа
                //случается потеря соединения при повторном запросе (сам в шоке)
                StreamReader sr = new StreamReader(temp);
                sr.ReadToEnd();


                if (ConnectionOK != null) ConnectionOK(this);

            }
            catch (WebException ex)
            {
                ErrorMessage = ex.Message;

                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    //ошибка протокола (404, например)
                    //интернет может и есть
                    
                    if (ProtocolError != null) ProtocolError(this);
                }
                else //какая-то другая ошибка
                {
                    if (NetworkError != null) NetworkError(this);
                }
            }

            //запускаем паузу            
            if (PauseTime > 0)
            {
                if (PauseStart != null) PauseStart(this);
                if (InternalTimer != null) InternalTimer.Start();
            }            
        }

        public void Start()
        {
            Stopped = false;
            wthread = new System.Threading.Thread(Request);
            wthread.Start();
        }

        public void Stop()
        {
            Stopped = true;
            if (InternalTimer != null)
            {
                InternalTimer.Stop();
                InternalTimer.Dispose();
                InternalTimer = null;
            }
            if (wthread != null)
            {
                wthread.Abort();
                wthread = null;
            }
            
            
        }

    }
}
