using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslitExample
{
    public class Translit
    {
        private Dictionary<char, string> TranslitDict = new Dictionary<char,string>();
        private bool compatibility = false;
        
        public bool Compatibility
        {
            get
            {
                return compatibility;
            }
            set
            {
                if (value)
                {
                    FormDictCompat();
                    compatibility = true;
                }
                else
                {
                    FormDictStandart();
                    compatibility = false;
                }
            }
        }

        public Translit(bool Compat)
        {
            Compatibility = Compat;
        }

        private void FormDictStandart()
        {
            TranslitDict.Clear();            

            //Big letter standart
            TranslitDict.Add('А', "A");
            TranslitDict.Add('Б', "B");
            TranslitDict.Add('В', "V");
            TranslitDict.Add('Г', "G");
            TranslitDict.Add('Д', "D");
            TranslitDict.Add('Е', "E");
            TranslitDict.Add('Ё', "Yo");
            TranslitDict.Add('Ж', "Zh");
            TranslitDict.Add('З', "Z");
            TranslitDict.Add('И', "I");
            TranslitDict.Add('Й', "J");
            TranslitDict.Add('К', "K");
            TranslitDict.Add('Л', "L");
            TranslitDict.Add('М', "M");
            TranslitDict.Add('Н', "N");
            TranslitDict.Add('О', "O");
            TranslitDict.Add('П', "P");
            TranslitDict.Add('Р', "R");
            TranslitDict.Add('С', "S");
            TranslitDict.Add('Т', "T");
            TranslitDict.Add('У', "U");
            TranslitDict.Add('Ф', "F");
            TranslitDict.Add('Х', "Kh");
            TranslitDict.Add('Ц', "Ts");
            TranslitDict.Add('Ч', "Ch");
            TranslitDict.Add('Ш', "Sh");
            TranslitDict.Add('Щ', "Shch");
            TranslitDict.Add('Ъ', "''");
            TranslitDict.Add('Ы', "Y");
            TranslitDict.Add('Ь', "'");
            TranslitDict.Add('Э', "E");
            TranslitDict.Add('Ю', "Ju");
            TranslitDict.Add('Я', "Ja");
            //end

            //Small letter standart
            TranslitDict.Add('а', "a");
            TranslitDict.Add('б', "b");
            TranslitDict.Add('в', "v");
            TranslitDict.Add('г', "g");
            TranslitDict.Add('д', "d");
            TranslitDict.Add('е', "e");
            TranslitDict.Add('ё', "yo");
            TranslitDict.Add('ж', "zh");
            TranslitDict.Add('з', "z");
            TranslitDict.Add('и', "i");
            TranslitDict.Add('й', "j");
            TranslitDict.Add('к', "k");
            TranslitDict.Add('л', "l");
            TranslitDict.Add('м', "m");
            TranslitDict.Add('н', "n");
            TranslitDict.Add('о', "o");
            TranslitDict.Add('п', "p");
            TranslitDict.Add('р', "r");
            TranslitDict.Add('с', "s");
            TranslitDict.Add('т', "t");
            TranslitDict.Add('у', "u");
            TranslitDict.Add('ф', "f");
            TranslitDict.Add('х', "kh");
            TranslitDict.Add('ц', "ts");
            TranslitDict.Add('ч', "ch");
            TranslitDict.Add('ш', "sh");
            TranslitDict.Add('щ', "shch");
            TranslitDict.Add('ъ', "''");
            TranslitDict.Add('ы', "y");
            TranslitDict.Add('ь', "'");
            TranslitDict.Add('э', "e");
            TranslitDict.Add('ю', "ju");
            TranslitDict.Add('я', "ja");
            //end
        }

        private void FormDictCompat()
        {
            TranslitDict.Clear();

            //Big letter compatibility
            TranslitDict.Add('А', "A");
            TranslitDict.Add('Б', "B");
            TranslitDict.Add('В', "V");
            TranslitDict.Add('Г', "G");
            TranslitDict.Add('Д', "D");
            TranslitDict.Add('Е', "E");
            TranslitDict.Add('Ё', "Yo");
            TranslitDict.Add('Ж', "Zh");
            TranslitDict.Add('З', "Z");
            TranslitDict.Add('И', "I");
            TranslitDict.Add('Й', "J");
            TranslitDict.Add('К', "K");
            TranslitDict.Add('Л', "L");
            TranslitDict.Add('М', "M");
            TranslitDict.Add('Н', "N");
            TranslitDict.Add('О', "O");
            TranslitDict.Add('П', "P");
            TranslitDict.Add('Р', "R");
            TranslitDict.Add('С', "S");
            TranslitDict.Add('Т', "T");
            TranslitDict.Add('У', "U");
            TranslitDict.Add('Ф', "F");
            TranslitDict.Add('Х', "Kh");
            TranslitDict.Add('Ц', "Ts");
            TranslitDict.Add('Ч', "Ch");
            TranslitDict.Add('Ш', "Sh");
            TranslitDict.Add('Щ', "Shch");
            TranslitDict.Add('Ъ', "_");
            TranslitDict.Add('Ы', "Y");
            TranslitDict.Add('Ь', "_");
            TranslitDict.Add('Э', "E");
            TranslitDict.Add('Ю', "Ju");
            TranslitDict.Add('Я', "Ja");            
            //end

            //Small letter compatibility
            TranslitDict.Add('а', "a");
            TranslitDict.Add('б', "b");
            TranslitDict.Add('в', "v");
            TranslitDict.Add('г', "g");
            TranslitDict.Add('д', "d");
            TranslitDict.Add('е', "e");
            TranslitDict.Add('ё', "yo");
            TranslitDict.Add('ж', "zh");
            TranslitDict.Add('з', "z");
            TranslitDict.Add('и', "i");
            TranslitDict.Add('й', "j");
            TranslitDict.Add('к', "k");
            TranslitDict.Add('л', "l");
            TranslitDict.Add('м', "m");
            TranslitDict.Add('н', "n");
            TranslitDict.Add('о', "o");
            TranslitDict.Add('п', "p");
            TranslitDict.Add('р', "r");
            TranslitDict.Add('с', "s");
            TranslitDict.Add('т', "t");
            TranslitDict.Add('у', "u");
            TranslitDict.Add('ф', "f");
            TranslitDict.Add('х', "kh");
            TranslitDict.Add('ц', "ts");
            TranslitDict.Add('ч', "ch");
            TranslitDict.Add('ш', "sh");
            TranslitDict.Add('щ', "shch");
            TranslitDict.Add('ъ', "_");
            TranslitDict.Add('ы', "y");
            TranslitDict.Add('ь', "_");
            TranslitDict.Add('э', "e");
            TranslitDict.Add('ю', "ju");
            TranslitDict.Add('я', "ja");
            //end

            //space
            TranslitDict.Add(' ', "_");
            
        }

        public string TranslitChar(char Rus)
        {
            if (TranslitDict.ContainsKey(Rus))
            {
                return TranslitDict[Rus];
            }
            else
            {
                return Rus.ToString();
            }
        }

        public string TranslitString(string Rus)
        {
            string sBuf = "";
            StringBuilder sb = new StringBuilder();

            if (compatibility)
            {
                if (!ContainsRusOrSpace(Rus)) return Rus;
            }
            else
            {
                if (!ContainsRus(Rus)) return Rus;
            }

            for (int i = 0; i < Rus.Length; i++)
            {
                if (TranslitDict.ContainsKey(Rus[i]))
                {
                    sBuf = TranslitDict[Rus[i]];
                }
                else
                {
                    sBuf = Rus[i].ToString();
                }
                
                sb.Append(sBuf);
            }

            return sb.ToString();
        }
        
        public static bool ContainsRus(string TestString)
        {
            return
                Regex.IsMatch(TestString, @"[а-я]", RegexOptions.IgnoreCase);
        }

        public static bool ContainsRusOrSpace(string TestString)
        {
            return
                Regex.IsMatch(TestString, @"[а-я]|\s", RegexOptions.IgnoreCase);
        }
    }
}
