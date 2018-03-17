using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class frmFontSettings : Form
    {
        public frmFontSettings()
        {
            InitializeComponent();
        }

        public FileFont fileFont = null;

        private void frmFontSettings_Load(object sender, EventArgs e)
        {
            lblFont.Location = new Point((this.Width - lblFont.Width) / 2,
                lblFont.Location.Y);

            chkBold.Checked = fileFont.Bold;
            chkItalic.Checked = fileFont.Italic;
            chkUnderline.Checked = fileFont.Underline;
            chkStrikeout.Checked = fileFont.Strikeout;
            numSize.Value = (decimal)fileFont.Size;

            lblFont.Font = fileFont.Font;

            
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            fileFont.Bold = chkBold.Checked;
            lblFont.Font = fileFont.Font;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            fileFont.Italic = chkItalic.Checked;
            lblFont.Font = fileFont.Font;
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            fileFont.Underline = chkUnderline.Checked;
            lblFont.Font = fileFont.Font;
        }

        private void chkStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            fileFont.Strikeout = chkStrikeout.Checked;
            lblFont.Font = fileFont.Font;
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            fileFont.Size = (float)numSize.Value;
            lblFont.Font = fileFont.Font;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblFont_Resize(object sender, EventArgs e)
        {
            lblFont.Location = new Point((this.Width - lblFont.Width) / 2,
                lblFont.Location.Y);
            //pnlButtons.Location = new Point(pnlButtons.Location.X,
            //    lblFont.Location.Y + lblFont.Height + 5);
            pnlButtons.Size=new Size(this.Width-5,pnlButtons.Height);

            this.Size = new Size(this.Width,
                pnlControls.Height + lblFont.Height + pnlButtons.Height+35);
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            fileFont.Regular = true;
            lblFont.Font = fileFont.Font;

            foreach (Control c in pnlControls.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
        
    }
}
