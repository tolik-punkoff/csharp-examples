using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Text;
using System.Drawing;

namespace tmpCodeTable
{
    public class FileFont
    {        
        private string fontfilename = "";
        private Font fnt = null;
        private FontStyle fstyle = FontStyle.Regular;
        private float size = 10;

        private Dictionary<string, FontStyle> styleset = new Dictionary<string, FontStyle>();
        
        private bool f_bold = false;
        private bool f_italic = false;
        private bool f_underline = false;
        private bool f_strikeout = false;

        public float Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public bool Regular
        {
            get
            {
                return IsRegular();
            }
            set
            {
                if (value)
                {
                    SetRegular();
                }
            }
        }

        public bool Bold
        {
            get
            {
                return f_bold;
            }
            set
            {
                SetStyle("Bold", value);
                f_bold = value;
            }
        }

        public bool Italic
        {
            get
            {
                return f_italic;
            }
            set
            {
                SetStyle("Italic", value);
                f_italic = value;
            }
        }

        public bool Underline
        {
            get
            {
                return f_underline;
            }
            set
            {
                SetStyle("Underline", value);
                f_underline = value;
            }
        }

        public bool Strikeout
        {
            get
            {
                return f_strikeout;
            }
            set
            {
                SetStyle("Strikeout", value);
                f_strikeout = value;
            }
        }

        public Font Font
        {
            get
            {
                BuildFont();
                return fnt;
            }            
        }

        public string FileName
        {
            get
            {
                return fontfilename;
            }
            set
            {
                fontfilename = value;
            }
        }

        public FileFont(string filename)
        {
            FileName = filename;            
            styleset.Add("Bold", FontStyle.Regular);
            styleset.Add("Italic", FontStyle.Regular);
            styleset.Add("Strikeout", FontStyle.Regular);
            styleset.Add("Underline", FontStyle.Regular);


            GlobalFontCollection.AddFont(FileName);                
        }

        private void BuildFont()
        {
            fstyle = FontStyle.Regular;
            foreach (string key in styleset.Keys)
            {
                fstyle = fstyle | styleset[key];
            }
            int idx = GlobalFontCollection.GetIndex(FileName);
            fnt = new Font(GlobalFontCollection.PFCollection.Families[idx], 
                size, fstyle);
        }

        private void SetRegular()
        {
            string[] keys = new string[styleset.Keys.Count];
            styleset.Keys.CopyTo(keys, 0);
            
            foreach (string key in keys)
            {
                styleset[key] = FontStyle.Regular;
            }
            
            f_bold = false;
            f_italic = false;
            f_strikeout = false;
            f_underline = false;
        }

        private void SetStyle(string StyleName, bool On)
        {
            if (!On)
            {
                styleset[StyleName] = FontStyle.Regular;
            }
            else
            {
                switch (StyleName)
                {
                    case "Bold": styleset[StyleName] = FontStyle.Bold; break;
                    case "Italic": styleset[StyleName] = FontStyle.Italic; break;
                    case "Strikeout": styleset[StyleName] = FontStyle.Strikeout; break;
                    case "Underline": styleset[StyleName] = FontStyle.Underline; break;

                }
            }
        }

        private bool IsRegular()
        {
            foreach (string key in styleset.Keys)
            {
                if (styleset[key] != FontStyle.Regular) return false;
            }

            return true;
        }
    }
}
