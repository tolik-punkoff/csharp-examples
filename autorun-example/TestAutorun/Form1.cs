using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestAutorun
{
    public partial class frmAutorun : Form
    {
        public frmAutorun()
        {
            InitializeComponent();
        }

        Autorun AppAutorun = null;
        AutorunStatus status = AutorunStatus.NoRun;

        private void frmAutorun_Load(object sender, EventArgs e)
        {
            AppAutorun = new Autorun("AutorunTest", Application.ExecutablePath);
            status = AppAutorun.Check(false);
            CheckStatus();
        }
        
        private void CheckStatus()
        {
            switch (status)
            {
                case AutorunStatus.Run:
                    {
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = true;
                    }; break;
                
                case AutorunStatus.NoRun:
                    {
                        btnAdd.Enabled = true;
                        btnRemove.Enabled = false;
                    }; break;
                
                case AutorunStatus.BadPath:
                    {
                        btnAdd.Enabled = true;
                        btnRemove.Enabled = true;
                    }; break;
                case AutorunStatus.Error:
                    {
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = false;
                    }; break;
            }

            lblStatus.Text = "STATUS: " + status.ToString();
            if (status == AutorunStatus.Error)
            {
                lblStatus.Text = lblStatus.Text + " (click to read)";
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            if (status == AutorunStatus.Error)
            {
                MessageBox.Show(AppAutorun.ErrorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((status == AutorunStatus.BadPath) &&
                (((Button)sender).Name == "btnAdd"))
            {
                status = AppAutorun.Check(true);
            }
            else
            {
                status = AppAutorun.Switch();
            }
            CheckStatus();
        }
    }
}
