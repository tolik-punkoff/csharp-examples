using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HideCaret
{
    public partial class frmCaretToEnd : Form
    {
        public frmCaretToEnd()
        {
            InitializeComponent();
        }

        public string SampleText = "";

        private void frmCaretToEnd_Load(object sender, EventArgs e)
        {
            txtSampleText.Text = SampleText;
            //ставим курсор в конец текста
            txtSampleText.SelectionStart = txtSampleText.Text.Length;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
