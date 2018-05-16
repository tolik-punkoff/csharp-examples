using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace TestInternetConnect
{
    public enum NetConnectionType
    {
        NoProxy = 0,
        SystemProxy = 1,
        ManualProxy = 2
    }
    public enum NetConfigStatus
    {
        OK=0,
        Error=1,
        ProxyPassNotDecrypted=2
    }
    
    public class NetSettings
    {
        private string configFile = "";
        private string TableName = "";
        private DataSet dsNetConfig = new DataSet();

        public NetConnectionType ConnectionType { get; set; }
        public string ProxyAddress { get; set; }
        public int ProxyPort { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPassword { get; set; }
        public bool SavePassword { get; set; }
        public int ConnectionTimeout { get; set; }

        public bool ShowChars { get; set; }
        public string ConfigError { get; private set; }


        public NetSettings(string filename)
        {            
            configFile = filename;
            TableName = this.GetType().Name;
            CreateDataSet();
        }
        
        public NetConfigStatus LoadConfig()
        {
            //файла нет, все по-умолчанию, потом будет создан новый
            if (!File.Exists(configFile)) return NetConfigStatus.OK;

            //файл есть, пробуем загрузить в DataSet
            try
            {
                dsNetConfig.ReadXml(configFile);
            }
            catch (Exception ex)
            {
                ConfigError = ex.Message;
                return NetConfigStatus.Error;
            }

            //загрузка полей класса из DataSet
            if (dsNetConfig.Tables[TableName].Rows.Count > 0)
            {
                PropertyInfo[] properties = this.GetType().GetProperties();
                foreach (PropertyInfo pr in properties)
                {
                    string propName = pr.Name;
                    object propValue = dsNetConfig.Tables[TableName].Rows[0][propName];
                    if (propValue.GetType() != typeof(System.DBNull))
                    {
                        pr.SetValue(this, propValue, null);
                    }
                }
                if (!DecryptPassword())
                {
                    ProxyPassword = null;
                    return NetConfigStatus.ProxyPassNotDecrypted;
                }
            }

            return NetConfigStatus.OK;
        }
        public bool SaveConfig()
        {
            if (!SavePassword)
            {
                ProxyPassword = null;
            }
            EncryptPassword();
            
            ConfigError = null;
            dsNetConfig.Tables[TableName].Rows.Clear();
            DataRow dr = dsNetConfig.Tables[TableName].NewRow();
            
            
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo pr in properties)
            {
                string propName = pr.Name;
                object propValue = pr.GetValue(this,null);
                dr[propName] = propValue;
            }

            dsNetConfig.Tables[TableName].Rows.Add(dr);

            try
            {
                dsNetConfig.WriteXml(configFile);
            }
            catch (Exception ex)
            {
                ConfigError = ex.Message;
                return false;
            }
            
            return true;
        }
        
        public static bool ShowSystemProxyWindow()
        {
            try
            {                
                Process.Start("rundll32.exe", "inetcpl.cpl, LaunchConnectionDialog");
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void CreateDataSet()
        {             
            dsNetConfig.Tables.Add(TableName);
            
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo pr in properties)
            {
                dsNetConfig.Tables[TableName].Columns.Add(pr.Name, pr.PropertyType);
            }
        }

        private byte[] GetEntropy(string EntropyString)
        {

            MD5 md5 = MD5.Create();
            return md5.ComputeHash(Encoding.UTF8.GetBytes(EntropyString));
        }

        private bool EncryptPassword()
        {
            if (string.IsNullOrEmpty(ProxyPassword)) return true;
            if (string.IsNullOrEmpty(ProxyAddress) || string.IsNullOrEmpty(ProxyUser))
                return false;

            byte[] entropy = GetEntropy(ProxyAddress + ProxyUser);
            byte[] pass = Encoding.UTF8.GetBytes(ProxyPassword);
            byte[] crypted=ProtectedData.Protect(pass, 
                entropy, DataProtectionScope.LocalMachine);
            ProxyPassword = Convert.ToBase64String(crypted);

            return true;
        }

        private bool DecryptPassword()
        {
            if (string.IsNullOrEmpty(ProxyPassword)) return true;
            if (string.IsNullOrEmpty(ProxyAddress) || string.IsNullOrEmpty(ProxyUser))
                return false;
                            
            byte[] pass = null;
            try
            {
                pass = Convert.FromBase64String(ProxyPassword);
            }
            catch (Exception ex)
            {
                ConfigError = ex.Message;
                return false;
            }
            byte[] entropy = GetEntropy(ProxyAddress + ProxyUser);

            try
            {
                pass = ProtectedData.Unprotect(pass, entropy, DataProtectionScope.LocalMachine);
            }
            catch (Exception ex)
            {
                ConfigError = ex.Message;
                return false;
            }
            ProxyPassword = Encoding.UTF8.GetString(pass);                
            
            return true;
        }

    }
}
