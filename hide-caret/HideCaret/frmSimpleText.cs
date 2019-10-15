using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HideCaret
{
    public partial class frmSimpleText : Form
    {
        public frmSimpleText()
        {
            InitializeComponent();
        }

        public string SampleText = "";

        private void frmSimpleText_Load(object sender, EventArgs e)
        {
            txtSampleText.Text = SampleText;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
