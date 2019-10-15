using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HideCaret
{
    public partial class frmHideCaret : Form
    {
        public frmHideCaret()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public string SampleText = "";

        private void frmHideCaret_Load(object sender, EventArgs e)
        {
            txtSampleText.Text = SampleText;
            //ставим курсор в конец текста
            txtSampleText.SelectionStart = txtSampleText.Text.Length;
        }

        private void frmHideCaret_Shown(object sender, EventArgs e)
        {
            HideCaret(txtSampleText.Handle);
        }
    }
}
