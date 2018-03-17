using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
       
        frmMain fMain = new frmMain();
        
        private void frmLoading_Load(object sender, EventArgs e)
        {
            fMain.Shown += new EventHandler(fMain_Shown);
            fMain.FormClosing += new FormClosingEventHandler(fMain_FormClosing);
        }

        void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        void fMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }        
        
        private void frmLoading_Shown(object sender, EventArgs e)
        {
            tmrStart.Start();
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            tmrStart.Stop();
            fMain.Show();            
        }                
        
    }
}
