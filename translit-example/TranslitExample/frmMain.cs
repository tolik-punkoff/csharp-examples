using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TranslitExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Translit trans = new Translit(false);

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblIsCyr.Text = "";
        }

        private void txtTestString_TextChanged(object sender, EventArgs e)
        {
            if (chkCompMode.Checked)
            {
                trans.Compatibility = true;
            }
            else
            {
                trans.Compatibility = false;
            }

            bool IsCur = false;
            if (trans.Compatibility)
            {
                IsCur = Translit.ContainsRusOrSpace(txtTestString.Text);
            }
            else
            {
                IsCur = Translit.ContainsRus(txtTestString.Text);
            }

            if (IsCur)
            {
                lblIsCyr.ForeColor = Color.Green;
                lblIsCyr.Text = "Содержит кириллицу";
                txtTranslit.Text = trans.TranslitString(txtTestString.Text);
            }
            else
            {
                lblIsCyr.ForeColor = Color.Red;
                lblIsCyr.Text = "Не содержит кириллицу";
                txtTranslit.Text = "";
            }
        }

        private void chkCompMode_CheckedChanged(object sender, EventArgs e)
        {
            txtTestString_TextChanged(null, null);
        }
    }
}
