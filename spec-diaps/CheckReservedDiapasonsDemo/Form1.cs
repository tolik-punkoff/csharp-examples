using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckReservedDiapasonsDemo
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text.Trim();
            string Info = string.Empty;
            string NF = string.Empty;

            if (!IPConverter.IsIP(IP))
            {
                MessageBox.Show(IP + " not IP address", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NF = IPConverter.ToStandForm(IP);
            if (IP != NF)
            {
                Info = Info + "IP address: " + NF + "\n";
                Info = Info + "Input: " + IP + "\n";
            }
            else
            {
                Info = Info + "IP address: " + IP + "\n";
            }

            string Result = DiapasonsChecker.CheckSpecDiaps(IP);
            if (Result == string.Empty)
            {
                Info = Info + "Not in reserved diapason.";
            }
            else
            {
                Info = Info + Result;
            }

            MessageBox.Show(Info, "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
