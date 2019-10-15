using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HideCaret
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnCaretInStart_Click(object sender, EventArgs e)
        {
            frmCaretInStart fCIS = new frmCaretInStart();
            fCIS.SampleText = Properties.Resources.SampleText;
            fCIS.ShowDialog();
        }

        private void btnCaretToEnd_Click(object sender, EventArgs e)
        {
            frmCaretToEnd fCTE = new frmCaretToEnd();
            fCTE.SampleText = Properties.Resources.SampleText;
            fCTE.ShowDialog();
        }

        private void btnChangeFocus_Click(object sender, EventArgs e)
        {
            frmChangeFocus fCF = new frmChangeFocus();
            fCF.SampleText = Properties.Resources.SampleText;
            fCF.ShowDialog();
        }

        private void btnHideCaret_Click(object sender, EventArgs e)
        {
            frmHideCaret fHC = new frmHideCaret();
            fHC.SampleText = Properties.Resources.SampleText;
            fHC.ShowDialog();
        }

        private void btnSimpleText_Click(object sender, EventArgs e)
        {
            frmSimpleText fST = new frmSimpleText();
            fST.SampleText = Properties.Resources.SampleText;
            fST.ShowDialog();
        }
    }
}
