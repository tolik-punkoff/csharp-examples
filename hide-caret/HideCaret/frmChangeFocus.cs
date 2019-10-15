using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HideCaret
{
    public partial class frmChangeFocus : Form
    {
        public frmChangeFocus()
        {
            InitializeComponent();
        }

        public string SampleText = "";

        private void frmChangeFocus_Load(object sender, EventArgs e)
        {
            txtSampleText.Text = SampleText;
            //ставим курсор в начало текста
            txtSampleText.SelectionStart = 0;

            //убираем курсор (сменой фокуса на другой элемент формы)
            btnClose.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
