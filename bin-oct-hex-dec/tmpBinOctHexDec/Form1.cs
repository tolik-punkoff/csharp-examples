using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpBinOctHexDec
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int CP = 0;

        private string Conv(int From, int To, string Numbers)
        {
            Numbers = Numbers.Trim();
            if (Numbers == string.Empty) return string.Empty;
            string[] buf = Numbers.Split(' ');
            string Out = "";            

            foreach (string s in buf)
            {
                try
                {                    
                    Out = Out + Convert.ToString(Convert.ToInt64(s, From), To) + " ";
                }
                catch
                {
                    Out = Out + Convert.ToString(Int64.MaxValue, To) + " ";
                }
            }

            return Out.Trim();
        }

        private string Conv(int From, string Numbers, int encID)
        {
            Numbers = Numbers.Trim();
            string[] buf = Numbers.Split(' ');
            string Out = "";

            foreach (string s in buf)
            {
                char ch = '\0';
                try
                {
                    byte bcode = Convert.ToByte(s, From);
                    
                    if (encID == 0)
                    {                        
                        ch = (char)bcode;
                    }
                    else
                    {                        
                        ch = Encoding.GetEncoding(encID).GetString(new byte[] { bcode })[0];
                    }
                    Out = Out +ch;
                }
                catch
                {
                    Out = Out+"'NOCHAR'";
                }
            }
            return Out;

        }

        private void txtBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '0') && (e.KeyChar != '1') &&
                (e.KeyChar != ' ') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtOct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                }
            }
            else
            {
                int digit = Convert.ToInt32(Convert.ToString(e.KeyChar));
                if (digit > 7)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                {
                    if ((e.KeyChar >= 'A') || (e.KeyChar <= 'F'))
                    {
                        e.KeyChar = e.KeyChar.ToString().ToLower()[0];
                    }

                    if ((e.KeyChar < 'a') || (e.KeyChar > 'f'))                        
                    {                        
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                }
            }
        }
        
        private void txtEncID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
                
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void All_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            bool changeBin = txtBin.Focused;
            bool changeOct = txtOct.Focused;
            bool changeHex = txtHex.Focused;
            bool changeDec = txtDec.Focused;

            switch (tb.Name)
            {
                case "txtBin":
                    {
                        
                        if (!changeOct) txtOct.Text = Conv(2, 8, tb.Text);
                        if (!changeHex) txtHex.Text = Conv(2, 16, tb.Text);
                        if (!changeDec) txtDec.Text = Conv(2, 10, tb.Text);

                    }; break;
                case "txtOct":
                    {
                        
                        if (!changeBin) txtBin.Text = Conv(8, 2, tb.Text);
                        if (!changeHex) txtHex.Text = Conv(8, 16, tb.Text);
                        if (!changeDec) txtDec.Text = Conv(8, 10, tb.Text);

                    }; break;
                case "txtHex":
                    {
                        
                        if (!changeBin) txtBin.Text = Conv(16, 2, tb.Text);
                        if (!changeOct) txtOct.Text = Conv(16, 8, tb.Text);
                        if (!changeDec) txtDec.Text = Conv(16, 10, tb.Text);

                    }; break;
                case "txtDec":
                    {
                        
                        if (!changeBin) txtBin.Text = Conv(10, 2, tb.Text);
                        if (!changeHex) txtHex.Text = Conv(10, 16, tb.Text);
                        if (!changeOct) txtOct.Text = Conv(10, 8, tb.Text);

                    }; break;
            }
            txtChr.Text = Conv(10, txtDec.Text, CP);
        }

        private void txtEncID_TextChanged(object sender, EventArgs e)
        {
            if (txtEncID.Text == string.Empty) return;
            CP = Convert.ToInt32(txtEncID.Text);
            try
            {
                lblEncName.Text = Encoding.GetEncoding(CP).EncodingName;
                txtChr.Text = Conv(10, txtDec.Text, CP);
            }
            catch
            {
                CP = 0;
                lblEncName.Text = "NOT SUPPORTED " + txtEncID.Text + " (Default 0)";
            }
        }

        
    }
}
