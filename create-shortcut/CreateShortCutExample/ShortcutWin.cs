using System;
using System.Collections.Generic;
using System.Text;
using IWshRuntimeLibrary;

namespace CreateShortCutExample
{
    public enum ShortcutWindowStyle
    {
        Normal = 1,
        Maximize = 3,
        Minimize = 7
    }

    public class ShortcutWin
    {
        WshShell wshShell = null;
        IWshShortcut Shortcut = null;

        private string workingDirectory = string.Empty;

        public string TargetPath { get; set; }
        public string ShortcutPath { get; set; }
        public string WorkingDirectory
        {
            get
            {
                return workingDirectory;
            }
            set
            {
                if (WorkingDirectory == null)
                {
                    workingDirectory =
                        System.IO.Path.GetDirectoryName(TargetPath);
                }
                else
                {
                    workingDirectory = WorkingDirectory;
                }
            }
        }
        public ShortcutWindowStyle WindowStyle { get; set;}
        public string Arguments { get; set; }
        public string IconFile { get; set; }
        public int IconIndex { get; set; }
        public string Description { get; set; }


        public ShortcutWin (string shortcutPath, string targetPath)
        {
            ShortcutPath = shortcutPath;
            TargetPath = targetPath;
            wshShell = new WshShell(); //создаем объект wsh shell
            
            Shortcut = (IWshShortcut)wshShell.
                CreateShortcut(ShortcutPath); //и объект для управления ярлыком

            Shortcut.TargetPath = TargetPath; //путь к целевому файлу
            
            WorkingDirectory = null;
            WindowStyle = ShortcutWindowStyle.Normal;
            Arguments = Description = string.Empty;
        }

        public bool SetHotkey(string Keyname, bool Ctrl, bool Alt, bool Shift, bool Ext)
        {
            string hotKey = string.Empty;

            if (Ctrl) hotKey = hotKey + "CTRL+";
            if (Alt) hotKey = hotKey + "ALT+";
            if (Shift) hotKey = hotKey + "SHIFT+";
            if (Ext) hotKey = hotKey + "EXT+";

            Keyname = Keyname.Trim();
            hotKey = hotKey + Keyname;
            if (!string.IsNullOrEmpty(Keyname))
            {
                try
                {
                    Shortcut.Hotkey = hotKey;
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        

        public void Create()
        {
            
            Shortcut.WorkingDirectory = workingDirectory;

            //стиль окна приложения
            Shortcut.WindowStyle = (int)WindowStyle;

            //Параметры командной строки
            Shortcut.Arguments = Arguments;

            //Иконка
            if (!string.IsNullOrEmpty(IconFile))
            {
                if (IconIndex == null) IconIndex = 0;
                string iconString = IconFile + ", " + IconIndex.ToString();
                Shortcut.IconLocation = iconString;
            }

            //Описание
            Shortcut.Description = Description;

            Shortcut.Save();
        }
        
    }
}
