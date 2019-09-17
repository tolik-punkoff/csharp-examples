using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace InputDigitExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        string StatusMessage = "";

        private void txtDigitsWithDots_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только цифр с одной точкой (запятой)
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(".") || txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
                return;
            }

            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только цифр
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }
        
        private void txtDigitsWithDotsAndMinus_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            int pos = txt.SelectionStart;

            //ввод точки (запятой)
            if ((txt.Text.StartsWith(".")) || (txt.Text.StartsWith(",")))
            {
                // добавление лидирующего ноля
                txt.Text = "0" + txt.Text;
                txt.SelectionStart = pos + 1;
            }

            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {                
                if (txt.Text.Contains(".") || txt.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }                

                return;
            }

            //ввод минуса
            if (e.KeyChar == '-')
            {                
                if (txt.Text.StartsWith("-"))
                {
                    txt.Text = txt.Text.Substring(1);
                    txt.SelectionStart = pos - 1;
                }
                else
                {
                    txt.Text = "-" + txt.Text;
                    txt.SelectionStart = pos + 1;
                }

                e.Handled = true;
                return;
            }

            //ввод цифр
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }            
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string txt_BoxName = txt.Name.Substring(3);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    string lbl_Name = lbl.Name.Substring(3);

                    if (txt_BoxName == lbl_Name)
                    {
                        lbl.Text = ToDouble(txt.Text).ToString();

                        if (StatusMessage.StartsWith("OK"))
                        {
                            lblConvertStatus.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblConvertStatus.ForeColor = Color.Red;
                        }
                        lblConvertStatus.Text = StatusMessage;
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDigitsWithDotsAndMinus.Text = "";
            lblDigitsWithDots.Text = "";
            lblOnlyDigits.Text = "";
        }

        private double ToDouble(string Number)
        {            
            Number = Number.Trim();
            if (Number == string.Empty) return 0;
            Number = Number.Replace(',', '.');
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            double Ret = 0;

            try
            {
                Ret = Convert.ToDouble(Number, format);
                StatusMessage = "OK" + " [STRING:" + Number + "]";
            }
            catch (Exception ex)
            {
                StatusMessage = ex.Message + " [STRING:" + Number + "]"; 
            }
            return Ret;
        }
        
    }
}
