using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;

namespace tmpCodeTable
{
    public static class GlobalFontCollection
    {
        public static PrivateFontCollection PFCollection = new PrivateFontCollection();
        private static Dictionary<string, int> FontsFiles = new Dictionary<string, int>();

        public static void AddFont(string FileName)
        {
            if (FontsFiles.ContainsKey(FileName)) return;

            PFCollection.AddFontFile(FileName);
            FontsFiles.Add(FileName, PFCollection.Families.Length - 1);
        }
        public static int GetIndex(string FileName)
        {
            if (!FontsFiles.ContainsKey(FileName)) return -1;
            return FontsFiles[FileName];
        }
    }
}
