using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtTest_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkKeyUp.Checked)
            {
                lvLog.Items.Add("Событие: KeyUp");
                if (e.Alt) lvLog.Items.Add("e.Alt: TRUE");
                if (e.Control) lvLog.Items.Add("e.Control: TRUE");
                if (e.Shift) lvLog.Items.Add("e.Shift: TRUE");
                lvLog.Items.Add("e.KeyCode: " + e.KeyCode.ToString()); //e.KeyCode
                lvLog.Items.Add("e.KeyData: " + e.KeyData.ToString()); //e.KeyData
                lvLog.Items.Add("e.KeyValue: " + e.KeyValue.ToString()); //e.KeyValue
                lvLog.Items.Add("e.Modifiers: " + e.Modifiers.ToString()); //e.Modifiers
                if (e.SuppressKeyPress) lvLog.Items.Add("e.SuppressKeyPress: TRUE");
                lvLog.EnsureVisible(lvLog.Items.Count - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvLog.Items.Clear();
        }

        private void txtTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkKeyDown.Checked)
            {
                lvLog.Items.Add("Событие: KeyDown");
                if (e.Alt) lvLog.Items.Add("e.Alt: TRUE");
                if (e.Control) lvLog.Items.Add("e.Control: TRUE");
                if (e.Shift) lvLog.Items.Add("e.Shift: TRUE");
                lvLog.Items.Add("e.KeyCode: " + e.KeyCode.ToString()); //e.KeyCode
                lvLog.Items.Add("e.KeyData: " + e.KeyData.ToString()); //e.KeyData
                lvLog.Items.Add("e.KeyValue: " + e.KeyValue.ToString()); //e.KeyValue
                lvLog.Items.Add("e.Modifiers: " + e.Modifiers.ToString()); //e.Modifiers
                if (e.SuppressKeyPress) lvLog.Items.Add("e.SuppressKeyPress: TRUE");
                lvLog.EnsureVisible(lvLog.Items.Count - 1);
            }
        }

        private void txtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkKeyPress.Checked)
            {
                lvLog.Items.Add("Событие: KeyPress");
                lvLog.Items.Add("e.KeyChar: " + e.KeyChar.ToString()); //e.KeyChar
                lvLog.EnsureVisible(lvLog.Items.Count - 1);
            }
        }
    }
}
