using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SetFocusToOpenForm
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void btnChild1_Click(object sender, EventArgs e)
        {
            if (IsFormOpen("frmChild1")) return;
            
            frmChild1 fChild1 = new frmChild1();
            fChild1.Show();
        }

        private void btnChild2_Click(object sender, EventArgs e)
        {
            if (IsFormOpen("frmChild2")) return;

            frmChild2 fChild2 = new frmChild2();
            fChild2.Show();
        }

        private bool IsFormOpen(string FormName)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == FormName)
                {
                    f.Focus();
                    return true;
                }
            }
            return false;
        }
    }
}
