using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Security;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace TestApp
{
    class SendRequest
    {
        public delegate void OnConnecting(object sender);                
        public event OnConnecting Connecting;        
        
        private HttpWebRequest request = null;
        private WebProxy proxy = null;        
        
        public string URL { get; set; }
        public string OutputFile { get; set; }
        public string Method { get; set; }
        public string CertHashString { get; set; }

        public NetConnectionType ConnectionType { get; set; }
        public string ProxyAddress { get; set; }
        public int ProxyPort { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPassword { get; set; }        
        public int ConnectionTimeout { get; set; }

        public string ErrorMessage { get; private set; }
        
        public SendRequest(string url, string outputfile)
        {
            URL = url;
            OutputFile = outputfile;
            Method = "GET";

            DisableIgnoreCertError();
            DisableValidateCert();
        }

        public void EnableIgnoreCertError()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                delegate { return true; };
        }

        public void DisableIgnoreCertError()
        {
            ServicePointManager.ServerCertificateValidationCallback = null;
        }

        public void EnableValidateCert()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                ValidateCert;
            
        }

        public void DisableValidateCert()
        {
            ServicePointManager.ServerCertificateValidationCallback = null;
        }

        private bool ValidateCert(object sender, X509Certificate cert,
            X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //все и так хорошо
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }

            //не передан хэш сертификата
            //значит и проверять нечего
            if (string.IsNullOrEmpty(CertHashString))
            {
                return false;
            }

            //получаем хэш сертификата сервера в виде строки
            string hashstring = cert.GetCertHashString();

            //если хэши полученного и известного 
            //сертификата совпадают - все ок.
            if (hashstring == CertHashString)
            {
                return true;
            }

            return false;
        }

        public bool CreateRequest()
        {
            //устанавливаем минимальные параметры для запроса
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(URL);
            }
            catch (Exception ex)
            {
                ErrorMessage = "Request Error: " + ex.Message;                 
                return false;
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
            request.Method = Method;

            return true;
        }
        
        public bool Send()
        {
            if (Connecting != null) Connecting(this);
            
            //получаем ответ
            HttpWebResponse resp = null;
            FileStream writeStream = null;            
            try
            {
                resp = (HttpWebResponse)request.GetResponse();
                //не вывалились в ошибку, значит все OK

                //заводим поток для записи выходного файла
                writeStream = new FileStream(OutputFile, FileMode.Create);
                int size = 1024; //размер буфера для обмена между потоками
                byte[] buf = new byte[size]; //буфер
                int count = 0; //для хранения фактически прочитанных байт

                //получаем поток ответа
                Stream RespStream = resp.GetResponseStream();

                //пишем данные в файл
                do
                {
                    count = RespStream.Read(buf, 0, size); //читаем кусками == size

                    if (count > 0) //данные есть?
                    {
                        writeStream.Write(buf, 0, count); //пишем фактически 
                        //прочитанное кол-во байт
                    }
                } while (count > 0);
                writeStream.Close(); //закрываем поток записи, сохраняем файл
            }
            catch (WebException webex)
            {
                //вылетели в ошибку веба - пытаемся закрыть поток
                if (writeStream != null) writeStream.Close();

                ErrorMessage = webex.Message;

                if (webex.Status == WebExceptionStatus.ProtocolError)
                {
                    //ошибка протокола (404, например)
                    //интернет может и есть
                    ErrorMessage = "Protocol Error: " + ErrorMessage;
                    return false;
                }
                else //какая-то другая ошибка интернетов
                {
                    ErrorMessage = "Network Error: " + ErrorMessage;
                    return false;
                }
            }
            catch (Exception ex) //другая ошибка (напр. I/O error)
            {
                //пытаемся закрыть поток
                if (writeStream != null) writeStream.Close();                
                ErrorMessage = "Other Error: " + ex.Message;
                return false;
            }

            return true;
        }                
    }
}
