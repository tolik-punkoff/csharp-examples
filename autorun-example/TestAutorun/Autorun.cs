using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace TestAutorun
{
    public enum AutorunStatus
    {
        Run = 0,
        NoRun = 1,
        BadPath = 2,
        Error = 3
    }
    public class Autorun
    {
        private RegistryKey MainKey = Registry.CurrentUser;
        private string RunSubKey = @"Software\Microsoft\Windows\CurrentVersion\Run";

        public string ValueName { get; set; }
        public string AppPath { get; set; }
        public string ErrorMessage { get; private set; }

        public Autorun(string valuename, string apppath)
        {
            ValueName = valuename;
            AppPath = apppath;
        }

        public AutorunStatus Add()
        {
            //удаление из автозагрузки

            try
            {
                //Пробуем открыть ключ
                MainKey.OpenSubKey(RunSubKey);                
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return AutorunStatus.Error;
            }

            try
            {
                //Добавляемся в автозагрузку
                MainKey.SetValue(ValueName,AppPath,RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                MainKey.Close();
                return AutorunStatus.Error;
            }

            MainKey.Close();
            return AutorunStatus.Run;
        }

        public AutorunStatus Remove()
        {
            //удаление из автозагрузки
            
            try
            {
                //Пробуем открыть ключ
                MainKey.OpenSubKey(RunSubKey);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return AutorunStatus.Error;
            }

            try
            {             
                //удаляем Value из ключа
                MainKey.DeleteValue(ValueName);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                MainKey.Close();
                return AutorunStatus.Error;
            }

            MainKey.Close();
            return AutorunStatus.NoRun;
        }

        public AutorunStatus Check(bool FixPath)
        {
            //проверка статуса автозагрузки
            string ValueData = "";
            
            try
            {                
                //Пробуем открыть ключ
                MainKey.OpenSubKey(RunSubKey);                
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return AutorunStatus.Error;
            }

            //пробуем считать значение записи автозагрузки
            try
            {
                ValueData = MainKey.GetValue(ValueName).ToString();
            }
            catch
            {
                //скорее всего записи нет, мы не в автозагрузке
                MainKey.Close();
                return AutorunStatus.NoRun;
            }
            
            MainKey.Close();
            //ключ есть, но путь к приложению неправильный
            if (ValueData != AppPath)
            {
                //если надо исправить
                if (FixPath)
                {
                    //добавляемся с текущим путем
                    return Add();
                }
                else
                {
                    return AutorunStatus.BadPath;
                }
            }
            
            return AutorunStatus.Run;
        }

        public AutorunStatus Switch()
        {
            AutorunStatus status = Check(true);

            switch (status)
            {
                case AutorunStatus.Run:
                    {
                        status = Remove();
                    }; break;
                
                case AutorunStatus.NoRun:
                    {
                        status = Add();
                    }; break;
            }

            return status;
        }

    }
}
