using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.IO;

namespace TestInternetConnect
{
    public class TestSettings
    {
        private string configFile = "";
        private string TableName = "";
        private DataSet dsTestConfig = new DataSet();

        public int PauseTime { get; set; }
        public string URL { get; set; }
        public string ConfigError { get; private set; }

        public TestSettings(string filename)
        {            
            configFile = filename;
            TableName = this.GetType().Name;
            CreateDataSet();
        }

        private void CreateDataSet()
        {
            dsTestConfig.Tables.Add(TableName);

            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo pr in properties)
            {
                dsTestConfig.Tables[TableName].Columns.Add(pr.Name, pr.PropertyType);
            }
        }

        public bool LoadConfig()
        {
            //файла нет, все по-умолчанию, потом будет создан новый
            if (!File.Exists(configFile)) return true;

            //файл есть, пробуем загрузить в DataSet
            try
            {
                dsTestConfig.ReadXml(configFile);
            }
            catch (Exception ex)
            {
                ConfigError = ex.Message;
                return false;
            }

            //загрузка полей класса из DataSet
            if (dsTestConfig.Tables[TableName].Rows.Count > 0)
            {
                PropertyInfo[] properties = this.GetType().GetProperties();
                foreach (PropertyInfo pr in properties)
                {
                    string propName = pr.Name;
                    object propValue = dsTestConfig.Tables[TableName].Rows[0][propName];
                    if (propValue.GetType() != typeof(System.DBNull))
                    {
                        pr.SetValue(this, propValue, null);
                    }
                }                
            }

            return true;
        }

        public bool SaveConfig()
        {         
            ConfigError = null;
            dsTestConfig.Tables[TableName].Rows.Clear();
            DataRow dr = dsTestConfig.Tables[TableName].NewRow();


            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo pr in properties)
            {
                string propName = pr.Name;
                object propValue = pr.GetValue(this, null);
                dr[propName] = propValue;
            }

            dsTestConfig.Tables[TableName].Rows.Add(dr);

            try
            {
                dsTestConfig.WriteXml(configFile);
            }
            catch (Exception ex)
            {
                ConfigError = ex.Message;
                return false;
            }

            return true;
        }


    }
}
