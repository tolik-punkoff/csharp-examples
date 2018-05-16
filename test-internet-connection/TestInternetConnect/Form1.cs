using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestInternetConnect
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool wait = true;
        private TestConnect test = null;
        TestSettings testSettings = null;
        NetSettings netSettings = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStopTest.Enabled = false;
            lblPause.Text = "";
        }        

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmNetworkSettings fNetworkSettings = new frmNetworkSettings();
            fNetworkSettings.ShowDialog();
        }

        private void btnTestConfig_Click(object sender, EventArgs e)
        {
            frmTestConfig fTestConfig = new frmTestConfig();
            fTestConfig.ShowDialog();
        }

        private void pbProgress_Paint(object sender, PaintEventArgs e)
        {
            if (wait)
            {
                Font fnt = new Font("Courier new", 12,FontStyle.Bold);
                e.Graphics.FillRectangle(Brushes.Black, 0, 0, pbProgress.Width-1, pbProgress.Height-1);
                e.Graphics.DrawString("Waiting...", fnt, Brushes.Lime, 0, 0);
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            btnTestConfig.Enabled = false;
            btnConfig.Enabled = false;

            btnStartTest.Enabled = false;
            btnStopTest.Enabled = true;
            wait = false;

            testSettings = new TestSettings(cf.TestConfigFile);
            testSettings.LoadConfig();
            netSettings = new NetSettings(cf.ConfigFile);
            netSettings.LoadConfig();
            test = new TestConnect(testSettings.URL);
            test.PauseTime = testSettings.PauseTime;
            test.ConnectionTimeout = netSettings.ConnectionTimeout;
            test.ConnectionType = netSettings.ConnectionType;
            test.ProxyAddress = netSettings.ProxyAddress;
            test.ProxyPassword = netSettings.ProxyPassword;
            test.ProxyPort = netSettings.ProxyPort;
            test.ProxyUser = netSettings.ProxyUser;
            

            test.ConnectionOK += new TestConnect.OnConnectionOK(test_ConnectionOK);
            test.NetworkError += new TestConnect.OnNetworkError(test_NetworkError);
            test.ProtocolError += new TestConnect.OnProtocolError(test_ProtocolError);
            test.PauseEnd += new TestConnect.OnPauseEnd(test_PauseEnd);
            test.PauseStart += new TestConnect.OnPauseStart(test_PauseStart);
            test.Connecting += new TestConnect.OnConnecting(test_Connecting);
            test.RequestError += new TestConnect.OnRequestError(test_RequestError);

            test.Start();
        }

        void test_RequestError(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                MessageBox.Show(test.ErrorMessage, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnStopTest.PerformClick();
            });
        }

        void test_Connecting(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblStatus.ForeColor = SystemColors.ControlText;
                lblStatus.Text = "Connecting " + testSettings.URL + "...";
                pbProgress.Image = Properties.Resources.connecting;
            });
        }

        void test_PauseStart(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblPause.Text = "PAUSE [" + testSettings.PauseTime.ToString() + " s]";
            });
        }

        void test_PauseEnd(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblPause.Text = "";
            });
            
        }

        void test_ProtocolError(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Protocol Error (click to image for read message)";
                lblStatus.ForeColor = Color.Red;
                pbProgress.Image = Properties.Resources.g3821_2;
            });
        }

        void test_NetworkError(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Network Error (click to image for read message)";
                lblStatus.ForeColor = Color.Red;
                pbProgress.Image = Properties.Resources.delete;
            });
        }

        void test_ConnectionOK(object sender)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblStatus.Text = "OK";
                lblStatus.ForeColor = Color.Green;
                pbProgress.Image = Properties.Resources.galochka_check_128x128;
            });

            //test.Stop();
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            test.Stop();
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Text = "Stopping...";
            tmrStopping.Start();            
        }

        private void pbProgress_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(test.ErrorMessage))
            {
                MessageBox.Show(test.ErrorMessage);
            }
        }

        private void tmrStopping_Tick(object sender, EventArgs e)
        {
            tmrStopping.Stop();

            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Text = "Waiting command...";

            lblPause.Text = "";
            pbProgress.Image = null;
            wait = true;
            btnStopTest.Enabled = false;
            btnTestConfig.Enabled = true;
            btnConfig.Enabled = true;
            btnStartTest.Enabled = true;
        }
    }
}
