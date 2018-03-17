using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class frmHexValue : Form
    {
        public frmHexValue()
        {
            InitializeComponent();
        }

        public int Max = 0x10FFFF;
        public int Min = 0x0;
        public int Value = 0;

        private void frmHexValue_Load(object sender, EventArgs e)
        {
            txtHEX.Text = Convert.ToString(Value, 16).ToUpperInvariant();
        }

        private void txtHEX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    if ((e.KeyChar >= 'a') || (e.KeyChar <= 'f'))
                    {
                        e.KeyChar = e.KeyChar.ToString().ToUpperInvariant()[0];
                    }

                    if ((e.KeyChar < 'A') || (e.KeyChar > 'F'))
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void txtHEX_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            if (txtHEX.Text == string.Empty)
            {
                Value = 0;
                return;
            }

            try
            {
                v = Convert.ToInt32(txtHEX.Text, 16);
            }
            catch
            {
                this.Text = "ERROR!!!";
                return;
            }

            if (v > Max)
            {
                this.Text = "MAX 0x" + Convert.ToString(Max, 16) + "!";
                btnOK.Enabled = false;
            }
            else
            {
                if (v < Min)
                {
                    this.Text = "MIN 0x" + Convert.ToString(Min, 16) + "!";
                    btnOK.Enabled = false;
                }
                else
                {
                    this.Text = "Enter HEX value";
                    Value = v;
                    btnOK.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if ((Value > Max) || (Value < Min)) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
