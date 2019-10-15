using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HideCaret
{
    public partial class frmCaretInStart : Form
    {
        public frmCaretInStart()
        {
            InitializeComponent();
        }

        public string SampleText = "";

        private void frmCaretInStart_Load(object sender, EventArgs e)
        {
            txtSampleText.Text = SampleText;
            
            //ставим курсор в начало текста
            txtSampleText.SelectionStart = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
