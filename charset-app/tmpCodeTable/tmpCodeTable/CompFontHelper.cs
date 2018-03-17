using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.IO;

namespace tmpCodeTable
{
    public class CompFont
    {
        public int Start=0;
        public int End=0;
        public Font Font=null;

        public bool InFile = false;
        public string FileName = "";

        public string FamilyName = "";

        public FontStyle Style = FontStyle.Regular;
        public float Size = 0;

        private PrivateFontCollection fontcoll = null;
        
        public bool InDiapasone(int Code)
        {
            if ((Code >= Start) && (Code <= End))
                return true;
            else
                return false;
        }

        public bool FromString(string CFData)
        {
            string[] buf = CFData.Split('/');

            if (buf.Length < 7) return false;

            try
            {
                Start = Convert.ToInt32(buf[0]);
                End = Convert.ToInt32(buf[1]);
                InFile = Convert.ToBoolean(buf[2]);
                FileName = buf[3];
                FamilyName = buf[4];
                Style = (FontStyle)Convert.ToInt32(buf[5]);
                Size = (float)Convert.ToDouble(buf[6]);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            string buf = Start.ToString() + "/" + End.ToString() + "/" + InFile.ToString() +
                "/" + FileName + "/" + FamilyName + "/" + ((int)Style).ToString() +
                "/" + Size.ToString();
            return buf;
        }

        public void CreateCompFont()
        {

            if (InFile)
            {                
                GlobalFontCollection.AddFont(FileName);
                int idx = GlobalFontCollection.GetIndex(FileName);
                Font = new Font(GlobalFontCollection.PFCollection.Families[idx], 
                    Size, Style);                
            }
            else
            {
                Font = new Font(FamilyName, Size, Style);
            }            
        }
         
    }    
    
    public class CompFontHelper
    {
        public static string FontFolder = System.Windows.Forms.Application.StartupPath +
            "\\Fonts";

        public static bool CheckFontFolder()
        {
            if (!Directory.Exists(FontFolder))
            {
                try
                {
                    Directory.CreateDirectory(FontFolder);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public static Dictionary<string, bool> ParseFontStyle(FontStyle fontStyle)
        {
            Dictionary<string, bool> Result = new Dictionary<string, bool>();
            
            string[] bufnames=Enum.GetNames(typeof(FontStyle));

            foreach (string s in bufnames)
            {
                Result.Add(s,false);
            }

            if (fontStyle == FontStyle.Regular)
            {
                Result["Regular"] = true;
                return Result;
            }

            FontStyle fs = fontStyle & FontStyle.Bold;
            if (fs == FontStyle.Bold) Result["Bold"] = true;

            fs = fontStyle & FontStyle.Italic;
            if (fs == FontStyle.Italic) Result["Italic"] = true;

            fs = fontStyle & FontStyle.Strikeout;
            if (fs == FontStyle.Strikeout) Result["Strikeout"] = true;

            fs = fontStyle & FontStyle.Underline;
            if (fs == FontStyle.Underline) Result["Underline"] = true;
            
            
            return Result;
        }
        public static void ApplyFontStyle(FontStyle Style, FileFont fileFont)
        {
            Dictionary<string, bool> styleparse = ParseFontStyle(Style);

            fileFont.Regular = styleparse["Regular"];
            fileFont.Bold = styleparse["Bold"];
            fileFont.Italic = styleparse["Italic"];
            fileFont.Strikeout = styleparse["Strikeout"];
            fileFont.Underline = styleparse["Underline"];
        }
        
        private List<CompFont> CFont = new List<CompFont>();        

        public bool LoadCompFontData(string FileName)
        {
            string[] buf = null;
            try
            {
                buf = File.ReadAllLines(FileName);
            }
            catch
            {
                return false;
            }
            
            CFont.Clear();            

            foreach (string s in buf)
            {
                string st = s.Trim();
                if (st == string.Empty) continue; //void string
                if (st.StartsWith("#")) continue; //comment
                st = AddPathFontFolder(st);
                CompFont cf = new CompFont();
                if (!cf.FromString(st))
                {
                    return false; //format error
                }
                else
                {
                    cf.CreateCompFont();
                    CFont.Add(cf);
                }                
            }

            return true;
        }

        private string AddPathFontFolder(string path)
        {
            path = path.Trim();
            if (path.Contains("*"))
            {
                path = path.Replace("*", FontFolder);
            }
            return path;
        }
        
        

        public Font GetFont(int Code)
        {
            if (Code < 0) return null;
            if (CFont.Count == 0) return null;            
            foreach (CompFont cf in CFont)
            {
                if (cf.InDiapasone(Code))
                {
                    cf.CreateCompFont();
                    return cf.Font;
                }
            }
            return null;
        }
        
        public void RemoveAt(int Index)
        {
            if (Index < CFont.Count) return;            

            CFont.RemoveAt(Index);            
        }
        
        public void Add(CompFont compFont)
        {
            CFont.Add(compFont);            
        }

        public List<CompFont> GetCompFonts()
        {
            return CFont;
        }

        public bool SaveCompFontData(string FileName)
        {
            if (CFont.Count == 0) return false;

            List<string> lstbuf = new List<string>();

            foreach (CompFont cf in CFont)
            {
                string s = cf.ToString();
                s = s.Replace(FontFolder, "*");
                lstbuf.Add(s);
            }

            string[] buf = lstbuf.ToArray();

            try
            {
                File.WriteAllLines(FileName, buf);
            }
            catch
            {
                return false;
            }

            return true;
        }
        
    }
}
