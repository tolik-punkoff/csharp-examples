using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class frmCompFont : Form
    {
        public frmCompFont()
        {
            InitializeComponent();
        }

        public CompFontHelper CompFHelper = null;

        private string InfoMess = "DEL - Clear value, Ctrl+E, Double click - Edit value," 
            +"Ctrl+Ins - Insert string, Ctrl+Del - Delete string";
        private Color ErrColor = Color.Red;
        private Color DefaultColor = SystemColors.ControlText;

        private void frmCompFont_Load(object sender, EventArgs e)
        {
            lblInfo.Text = InfoMess;
            if (CompFHelper == null) return;
            LoadCompFont();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdCompFont.Rows.Add();
        }
       
        private void grdCompFont_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = grdCompFont.Columns[e.ColumnIndex].Name;
            DataGridViewCell c = grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                Cells[name];
            object v = c.Value;

            frmHexValue fHexVal = new frmHexValue();

            switch (name)
            {
                case "clStart":
                    {
                        object max = grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                            Cells["clEnd"].Value;
                        if (max == null) max = 0x10FFFF;
                        fHexVal.Min = 0;
                        fHexVal.Max = (int)max;
                        if (v == null) v = 0;
                        fHexVal.Value = (int)v;
                        DialogResult Ans = fHexVal.ShowDialog();
                        if (Ans == DialogResult.Cancel) return;
                        c.Value = fHexVal.Value;
                    }; break;
                case "clEnd":
                    {
                        object min = grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                            Cells["clStart"].Value;
                        if (min == null) min = 0;

                        fHexVal.Min = (int)min;
                        fHexVal.Max = 0x10FFFF;
                        if (v == null) v = 0;
                        fHexVal.Value = (int)v;
                        DialogResult Ans = fHexVal.ShowDialog();
                        if (Ans == DialogResult.Cancel) return;
                        c.Value = fHexVal.Value;
                    }; break;
                case "clFont":
                    {
                        DialogResult Ans = dlgFont.ShowDialog();
                        if (Ans == DialogResult.Cancel) return;
                        c.Value = dlgFont.Font.FontFamily.Name;
                        grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                                    Cells["clFontOptions"].Value
                                    = dlgFont.Font;
                        grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                                    Cells["clFile"].Value
                                    = null;

                    }; break;
                case "clFile":
                    {
                        dlgOpen.InitialDirectory = CompFontHelper.FontFolder;
                        dlgOpen.Filter = "TTF files|*.ttf";
                        DialogResult Ans = dlgOpen.ShowDialog();
                        if (Ans == DialogResult.Cancel) return;
                        if (((string)c.Value) == dlgOpen.FileName) return;
                        c.Value = dlgOpen.FileName;
                        FileFont ff = new FileFont((string)c.Value);
                        grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                                    Cells["clFontOptions"].Value
                                    = ff.Font;
                        grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                                    Cells["clFont"].Value
                                    = null;

                    };break;
                case "clFontOptions":
                    {
                        System.Drawing.Font fnt = null;
                        
                        object ofontfamily = grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                            Cells["clFont"].Value;
                        object ofontfile = grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                            Cells["clFile"].Value;

                        if (ofontfile == null)
                        {
                            if (ofontfamily == null)
                            {
                                MessageBox.Show("No font or font file selected!", "Error");
                            }
                            else
                            {
                                if (v == null)
                                {
                                    fnt = new Font((string)ofontfamily, 8, FontStyle.Regular);
                                }
                                else
                                {
                                    fnt = (System.Drawing.Font)v;
                                }
                                
                                DialogResult Ans = dlgFont.ShowDialog();
                                if (Ans == DialogResult.Cancel) return;
                                c.Value = dlgFont.Font;
                                grdCompFont.Rows[grdCompFont.CurrentRow.Index].
                                    Cells["clFont"].Value = dlgFont.Font.FontFamily.Name;
                            }
                        }
                        else
                        {
                            FileFont ff = new FileFont((string)ofontfile);
                            if (v == null)
                            {
                                fnt = new Font(ff.Font.FontFamily, 8, FontStyle.Regular);
                            }
                            else
                            {
                                fnt = (Font)v;
                                Dictionary <string,bool> style = 
                                    CompFontHelper.ParseFontStyle(fnt.Style);
                                ff.Bold = style["Bold"];
                                ff.Italic = style["Italic"];
                                ff.Underline = style["Underline"];
                                ff.Strikeout = style["Strikeout"];
                                ff.Size = fnt.Size;                                
                            }

                            frmFontSettings fFontSettings = new frmFontSettings();
                            fFontSettings.fileFont = ff;
                            DialogResult Ans = fFontSettings.ShowDialog();
                            if (Ans == DialogResult.Cancel) return;
                            ff = fFontSettings.fileFont;
                            c.Value = ff.Font;
                        }                        
                    }; break;
            }
        }

        private void grdCompFont_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string name = grdCompFont.Columns[e.ColumnIndex].Name;
            DataGridViewCell c = grdCompFont.Rows[e.RowIndex].
                Cells[name];
            object v = c.Value;


            switch (name)
            {
                case "clStart":
                    {
                        e.Value = Convert.ToString(Convert.ToInt32(v), 16)
                            .ToUpperInvariant();
                    }; break;
                case "clEnd":
                    {
                        e.Value = Convert.ToString(Convert.ToInt32(v), 16)
                            .ToUpperInvariant();
                    }; break;
                case "clFontOptions":
                    {
                        if (v == null)
                        {
                            e.Value = "<Not set>";
                        }
                        else
                        {
                            System.Drawing.Font fnt = (Font)v;
                            string s = fnt.Style.ToString() + ";" +
                                fnt.Size.ToString();
                            e.Value = s;
                        }                        
                    }; break;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int idx = -1;
            if (grdCompFont.CurrentRow == null) return;

            idx = grdCompFont.CurrentRow.Index;
            grdCompFont.Rows.RemoveAt(idx);
        }

        private bool Check()
        {            
            lblInfo.Text = InfoMess;
            lblInfo.ForeColor = DefaultColor;
            string ErrMess = "";

            if (grdCompFont.Rows.Count == 0)
            {
                lblInfo.ForeColor = ErrColor;
                ErrMess = "No fonts and diapasons added!";
                lblInfo.Text = ErrMess;
                return false;
            }
            for (int i = 0; i < grdCompFont.Rows.Count;i++)
            {
                grdCompFont.Rows[i].DefaultCellStyle.BackColor = Color.White;
                if (grdCompFont.Rows[i].Cells["clStart"].Value == null)
                    grdCompFont.Rows[i].Cells["clStart"].Value = 0;
                int tstart = (int)grdCompFont.Rows[i].Cells["clStart"].Value;
                
                if (grdCompFont.Rows[i].Cells["clEnd"].Value == null)
                    grdCompFont.Rows[i].Cells["clEnd"].Value = 0;
                int tend = (int)grdCompFont.Rows[i].Cells["clEnd"].Value;

                if (tstart > tend)
                {
                    grdCompFont.Rows[i].DefaultCellStyle.BackColor = ErrColor;
                    lblInfo.ForeColor = ErrColor;
                    ErrMess = "Start > End at string " + i.ToString();
                    lblInfo.Text = ErrMess;
                    return false;
                }
                
                if ((grdCompFont.Rows[i].Cells["clFont"].Value == null) &&
                    (grdCompFont.Rows[i].Cells["clFile"].Value == null))
                {
                    grdCompFont.Rows[i].DefaultCellStyle.BackColor = ErrColor;
                    lblInfo.ForeColor = ErrColor;
                    ErrMess = "No font set at string "+i.ToString();
                    lblInfo.Text = ErrMess;
                    return false;
                }

                if (grdCompFont.Rows[i].Cells["clFontOptions"].Value == null)
                {
                    System.Drawing.Font fnt = new Font("Microsoft Sans Serif", 10,
                        FontStyle.Regular);
                }
            }

            return true;
        }
        
        private void SaveCompFont()
        {
            CompFHelper = new CompFontHelper();

            for (int i = 0; i < grdCompFont.Rows.Count; i++)
            {
                CompFont cf = new CompFont();
                cf.Start = (int)grdCompFont.Rows[i].Cells["clStart"].Value;
                cf.End = (int)grdCompFont.Rows[i].Cells["clEnd"].Value;
                cf.Style = ((System.Drawing.Font)grdCompFont.Rows[i].Cells["clFontOptions"].Value).Style;
                cf.Size = ((System.Drawing.Font)grdCompFont.Rows[i].Cells["clFontOptions"].Value).Size;
                object fontfilename = grdCompFont.Rows[i].Cells["clFile"].Value;                

                if (fontfilename != null)
                {
                    cf.InFile = true;
                    cf.FileName = (string)fontfilename;
                }
                else
                {
                    cf.FamilyName = (string)grdCompFont.Rows[i].Cells["clFont"].Value;
                }
                
                CompFHelper.Add(cf);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Check()) return;

            dlgSave.InitialDirectory = CompFontHelper.FontFolder;
            dlgSave.Filter = "Composite font (*.cf)|*.cf";
            DialogResult Ans = dlgSave.ShowDialog();
            if (Ans == DialogResult.Cancel) return;

            SaveCompFont();
            
            if (!CompFHelper.SaveCompFontData(dlgSave.FileName))
            {
                lblInfo.ForeColor = ErrColor;
                lblInfo.Text = "Save file error!";
            }
            else
            {                
                lblInfo.ForeColor = DefaultColor;
                lblInfo.Text = InfoMess;
            }
        }

        private void LoadCompFont()
        {
            List<CompFont> lstCF = CompFHelper.GetCompFonts();

            grdCompFont.Rows.Clear();
            foreach (CompFont cf in lstCF)
            {
                grdCompFont.Rows.Add();
                grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clStart"].Value
                    = cf.Start;
                grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clEnd"].Value
                    = cf.End;
                if (cf.InFile)
                {
                    grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clFile"].Value
                        = cf.FileName;
                    grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clFont"].Value
                        = null;
                }
                else
                {
                    grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clFile"].Value
                        = null;
                    grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clFont"].Value
                        = cf.FamilyName;
                }
                grdCompFont.Rows[grdCompFont.Rows.Count - 1].Cells["clFontOptions"].Value
                    = CompFHelper.GetFont(cf.Start);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = CompFontHelper.FontFolder;
            dlgOpen.Filter = "Composite font (*.cf)|*.cf";
            DialogResult Ans = dlgOpen.ShowDialog();
            if (Ans == DialogResult.Cancel) return;

            CompFHelper = new CompFontHelper();

            if (!CompFHelper.LoadCompFontData(dlgOpen.FileName))
            {
                lblInfo.ForeColor = ErrColor;
                lblInfo.Text = "Load file error!";
                return;
            }

            LoadCompFont();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Check()) return;
            SaveCompFont();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void frmCompFont_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        {
                            btnDel.PerformClick();
                        }; break;
                    case Keys.Insert:
                        {
                            btnAdd.PerformClick();
                        }; break;
                    case Keys.E:
                        {
                            if (grdCompFont.CurrentCell == null) return;
                            DataGridViewCellEventArgs arge =
                                new DataGridViewCellEventArgs(grdCompFont.CurrentCellAddress.X,
                                    grdCompFont.CurrentCellAddress.Y);
                            grdCompFont_CellDoubleClick(null, arge);
                        }; break;
                }
            }

            if (e.KeyData  == Keys.Delete)
            {
                if (grdCompFont.CurrentCell == null) return;
                grdCompFont.CurrentCell.Value = null;
            }
        }
    }
}
