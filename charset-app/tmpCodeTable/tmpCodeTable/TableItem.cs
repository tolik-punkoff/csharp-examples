using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

public enum NumericNotation
{
    DEC = 10,
    HEX = 16,
    OCT = 8,
    BIN = 2
}

namespace tmpCodeTable
{
    public partial class TableItem : UserControl
    {        
        private Font DefFont = null;
        private Font ChrFont = null;
        private int code = 0;
        private string Ch = "";
        private NumericNotation nn = NumericNotation.DEC;
        
        public NumericNotation  CodeFormat {
            get
            {
                return nn;
            }
            set
            {
                nn = value;
                SetCode(code);
            }
        }

        public Font SymFont {
            get
            {
                return ChrFont;
            }
            set
            {
                ChrFont = value;
                SetChr();
            }
        }
        public int Code
        {
            get
            {
                if (code < 0) return 0;
                return code;
            }
            set
            {
                code = value;
                SetCode(code);
            }
        }

        public string Chr
        {
            get
            {
                return Ch;
            }
            set
            {                
                Ch = value;
                SetChr();
            }
        }

        public int ChrWidth
        {
            get
            {
                return txtChar.Width;
            }
            set
            {
                txtChar.Width = value;
            }
        }

        public int ChrHeight
        {
            get
            {
                return txtChar.Height;
            }
            set
            {
                txtChar.Height = value;
            }
        }
        
        public TableItem()
        {
            InitializeComponent();
            Ch = string.Empty;
            code = -1;
            DefFont = txtChar.Font;
            ChrFont = DefFont;
            SetChr();
            SetCode(code);

            txtChar.SelectionAlignment = HorizontalAlignment.Center;
        }
       
        public void SetDefaultFont()
        {
            ChrFont = DefFont;
            SetChr();
        }

        public void Clear()
        {
            Ch = " ";
            SetChr();
            code = -1;
            txtCode.Text = string.Empty;
            Ch = string.Empty;
        }
       
        private void SetCode(int c)
        {
            if (c < 0)
            {
                txtCode.Text = string.Empty;
            }
            else
            {
                txtCode.Text = Convert.ToString(c, (int)nn).ToUpperInvariant();
            }
        }
        
        private void SetChr()
        {
            if (txtChar.Font != ChrFont)
            {
                txtChar.Font = ChrFont;
            }

            txtChar.Text = Ch;
            
            Graphics g = Graphics.FromHwnd(txtChar.Handle);
            int newheight = g.MeasureString(Ch, ChrFont).ToSize().Height;
            
            
            if (txtChar.Height!=newheight)
            {
                txtChar.Height = newheight;
            }
        }
        

        private void txtChar_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            RichTextBox RTB = (RichTextBox)sender;
            //RTB.Height = 13;            
            RTB.Height = e.NewRectangle.Height;            

             //RTB.Height = (RTB.GetLineFromCharIndex(RTB.Text.Length) + 1) *
            //           RTB.Font.Height + RTB.Margin.Vertical;
           
        }
        
    }
}
