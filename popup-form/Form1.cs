using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PopupForm
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmPopup fPopup = new frmPopup();
            fPopup.MessageText = Properties.Resources.sampletext;
            fPopup.Show();
        }

        private void niMain_Click(object sender, EventArgs e)
        {
            btnTest.PerformClick();
        }
    }
}
