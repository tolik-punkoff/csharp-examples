using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testDynNotifyIcon
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        int iwidth = 16; int iheight = 16;
        string DSt = "";
        Font fnt = null;
        Bitmap bitm = null;

        [System.Runtime.InteropServices.DllImport("user32.dll", 
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private void frmTest_Load(object sender, EventArgs e)
        {
            fnt = new Font("Courier new", 8, FontStyle.Bold);
            bitm = new Bitmap(iwidth, iheight);        
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (txtTest.Text.Trim() == "") return;
            DSt = txtTest.Text.Trim();

            Graphics graph = Graphics.FromImage(bitm);
            graph.FillRectangle(Brushes.Black, 0, 0, iwidth, iheight);
            graph.DrawString(DSt,fnt,Brushes.Lime, new Point(0,2));
            
            IntPtr hIcon = bitm.GetHicon();
            
            System.Drawing.Icon niicon = System.Drawing.Icon.FromHandle(hIcon);
            niTest.Icon = niicon;

            DestroyIcon(niicon.Handle);
        }
        
    }
}
