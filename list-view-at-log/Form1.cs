using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.StatusChanged += new Worker.OnStatusChanged(w_StatusChanged);
            w.StartProcess();
        }

        void w_StatusChanged(object sender, WorkerEventArgs e)
        {   
            Invoke((MethodInvoker)delegate
            {
                lvOut.Items.Add(e.Message);
                lvOut.TopItem = lvOut.Items[lvOut.Items.Count - 1];
            });
        }
    }
}
