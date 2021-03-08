using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace FindFilesByMask
{
    public static class FindFiles
    {
        private static string AddSlash(string st)
        {
            if (st.EndsWith("\\"))
            {
                return st;
            }

            return st + "\\";
        }

        private static string GetNameOnly(string FullName)
        {
            int LastSlash = FullName.LastIndexOf("\\");
            
            if (LastSlash == -1) return FullName;

            return FullName.Substring(LastSlash + 1);
        }

        private static string Mask2Reg(string Mask)
        {
            //точка в маске файла должна быть точкой в регулярном выражении
            //экранируем
            Mask = Mask.Replace(".", "\\.");
            //^,$,{,},[,],(,),+ в regexp служебные, в именах файла допустимые
            //экранируем
            Mask = Mask.Replace("^", "\\^");
            Mask = Mask.Replace("$", "\\$");
            Mask = Mask.Replace("{", "\\{");
            Mask = Mask.Replace("}", "\\}");
            Mask = Mask.Replace("[", "\\[");
            Mask = Mask.Replace("[", "\\[");
            Mask = Mask.Replace("(", "\\(");
            Mask = Mask.Replace(")", "\\(");
            Mask = Mask.Replace("+", "\\+");
            //* - любое количество любого символа, 
            //в regexp любой символ - точка, любое количество *
            Mask = Mask.Replace("*", ".*");
            //? - любой символ, в regexp любой символ - точка.
            Mask = Mask.Replace("?", ".");

            //добавляем начало и конец строки к имени файла.
            Mask = "^" + Mask + "$";

            return Mask;
        }
        
        public static string[] Find(string sPath, string sMask, SearchOption SO)
        {
            string MaskRegStr = Mask2Reg(sMask);
            sPath = AddSlash(sPath);
            List<string> FoundFiles = new List<string>();
            Regex MaskReg = new Regex(MaskRegStr, RegexOptions.IgnoreCase);

            string[] files = Directory.GetFiles(sPath, sMask, SO);

            foreach (string filename in files)
            {                                
                if (MaskReg.IsMatch(GetNameOnly(filename)))
                {
                    FoundFiles.Add(filename);
                }
            }
            return FoundFiles.ToArray();
        }
    }
}
