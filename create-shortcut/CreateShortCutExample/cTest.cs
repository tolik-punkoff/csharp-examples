using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CreateShortCutExample
{
    public static class cTest
    {
        private static string testdir = Path.GetTempPath()+
                "shortcut\\";
        private static string targetfile = Directory.GetParent(
                Environment.GetFolderPath(Environment.SpecialFolder.System)) +
                "\\notepad.exe";
        private static string inkiconfile =Environment.GetFolderPath(Environment.SpecialFolder.System)+
                                        "\\shell32.dll"; //, 166
        
        public static void Test()
        {
            if (!Directory.Exists(testdir)) Directory.CreateDirectory(testdir);
            
            ShortcutWin shortcut = new ShortcutWin(testdir + "test1.lnk",
                targetfile);
            
            //создание ярлыка с минимальными параметрами
            shortcut.Create();

            //создание ярлыка с нужным рабочим каталогом
            shortcut = new ShortcutWin(testdir + "test2.lnk",
                targetfile);            
            shortcut.WorkingDirectory = "C:\\";
            shortcut.Create();

            //создание ярлыка, стиль окна - развернуть
            shortcut = new ShortcutWin(testdir + "test3.lnk",
                targetfile);
            shortcut.WindowStyle = ShortcutWindowStyle.Maximize;
            shortcut.Create();

            //создание ярлыка, параметры командной строки
            shortcut = new ShortcutWin(testdir + "test4.lnk",
                targetfile);
            shortcut.Arguments = testdir + "file.txt";
            shortcut.Create();

            //создание ярлыка, смена иконки
            shortcut = new ShortcutWin(testdir + "test5.lnk",
                targetfile);            
            shortcut.IconFile = inkiconfile;
            shortcut.IconIndex = 166;
            shortcut.Create();

            //создание ярлыка, описание
            shortcut = new ShortcutWin(testdir + "test6.lnk",
                targetfile);            
            shortcut.Description = "Тестовый ярлык";
            shortcut.Create();

            //создание ярлыка, горячая клавиша            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            shortcut = new ShortcutWin(desktop + "\\TestHotKey.lnk",
                targetfile);
            shortcut.SetHotkey("N", true, true, false, false);
            shortcut.Create();
            System.Diagnostics.Process.Start("explorer.exe", testdir);
            
        }
    }
}
