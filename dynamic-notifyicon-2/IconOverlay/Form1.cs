using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace IconOverlay
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        Icon TargetIcon = Properties.Resources.target;
        Bitmap TargetBitmap = null;
        Bitmap ResultBitmap = null;
        Bitmap OverlayBitmap = null;
        IconConverter icconv = null;

        [System.Runtime.InteropServices.DllImport("user32.dll",
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private void frmTest_Load(object sender, EventArgs e)
        {
            //convert icon to bitmap (target)
            icconv = new IconConverter();
            TargetBitmap = (Bitmap)icconv.ConvertTo(TargetIcon, typeof(Bitmap));
            
            //overlay bitmap
            OverlayBitmap = Properties.Resources.overlay;

            //create result bitmap
            ResultBitmap = new Bitmap(TargetBitmap.Width, TargetBitmap.Height,
                PixelFormat.Format32bppArgb);

            //create Graphics
            Graphics graph = Graphics.FromImage(ResultBitmap);
            graph.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            //Draw overlay images
            graph.DrawImage(TargetBitmap, 0, 0);
            graph.DrawImage(OverlayBitmap, 0, TargetBitmap.Height-OverlayBitmap.Height);            
            
            //result =)
            pbTarget.Image = TargetBitmap;
            pbOverlay.Image = OverlayBitmap;
            pbResult.Image = ResultBitmap;

            
        }

        private void btnShowIcon_Click(object sender, EventArgs e)
        {
            IntPtr hIcon = ResultBitmap.GetHicon();

            System.Drawing.Icon niicon = System.Drawing.Icon.FromHandle(hIcon);
            niTest.Icon = niicon;

            DestroyIcon(niicon.Handle);            
        }

        private void btnHideIcon_Click(object sender, EventArgs e)
        {
            niTest.Icon = null;
        }

        private void btnMainIcon_Click(object sender, EventArgs e)
        {
            niTest.Icon = Properties.Resources.target;
        }
    }
}
