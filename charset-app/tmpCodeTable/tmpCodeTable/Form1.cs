using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();            
        }

        TableItem[] TableItems = new TableItem[256];

        List<int> CPs = new List<int>();
        int CP = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {

            int NextX = 5; int NextY = 35;            
            for (int i = 0; i< 256; i++)
            {                
                TableItems[i] = new TableItem();                
                TableItems[i].Name = "TableItem" + i.ToString();

                TableItems[i].Location = new Point(NextX, NextY);
                TableItems[i].AutoSize = true;
                TableItems[i].Size = new System.Drawing.Size(51, 35);
                TableItems[i].TabIndex = i;

                if (((i+1) % 16) == 0)
                {
                    NextY = NextY + TableItems[i].Height;
                    NextX = 5;
                }
                else
                {
                    NextX = NextX + TableItems[i].Width;                                                            
                }

                Controls.Add(TableItems[i]);
            }

            EncodingInfo[] ei = Encoding.GetEncodings();
            foreach (EncodingInfo einfo in ei)
            {
                int cp = einfo.CodePage;
                string name = einfo.Name;                
                bool singlebyte = Encoding.GetEncoding(cp).IsSingleByte;

                if (singlebyte)
                {
                    CPs.Add(cp);
                    cmbCP.Items.Add(name);
                }
                
            }

            lblCPName.Text = Encoding.GetEncoding(0).EncodingName
                + " [" + Encoding.GetEncoding(0).CodePage.ToString() + "]";

            CP = Encoding.GetEncoding(0).CodePage;

            FillTable();
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void FillTable()
        {
            Encoding enc = Encoding.GetEncoding(CP);
            for (int i = 0; i < 256; i++)
            {
                TableItems[i].Chr = enc.GetString(new byte[] { (byte)i });
                TableItems[i].Code = i;                
            }
        }

        private void cmbCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CP = CPs[cmbCP.SelectedIndex];
            lblCPName.Text = cmbCP.SelectedItem.ToString() + " [" + CP.ToString() + "]";
            FillTable();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult Ans = dlgFont.ShowDialog();
            if (Ans == DialogResult.Cancel) return;

            for (int i = 0; i < 256; i++)
            {
                TableItems[i].SymFont = dlgFont.Font;                
            }

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            this.AutoSize = !this.AutoSize;

            if (!this.AutoSize)
            {
                this.Size = new Size(638, 478);
                btnAutoSize.Text = "AutoSize On";
            }
            else
            {
                btnAutoSize.Text = "AutoSize Off";
            }

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void btnEncodingsInfo_Click(object sender, EventArgs e)
        {
            frmEncInfo fEI = new frmEncInfo();
            fEI.ShowDialog();
        }

        

        
    }

}
