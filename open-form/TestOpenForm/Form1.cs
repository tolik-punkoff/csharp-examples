using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestOpenForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            lblFormOpened.Text = "";
            
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmChild")
                {
                    lblFormOpened.Text = "Form #2 already opened!";
                    return;
                }
            }
            frmChild fChild = new frmChild();
            fChild.Show();
        }
    }
}
