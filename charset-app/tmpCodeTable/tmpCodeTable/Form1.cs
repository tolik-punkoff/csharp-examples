using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private System.Drawing.Size oldSize = new System.Drawing.Size();
        int StartX = 5; int StartY = 35;
        int AddY = 25;
        NumericNotation CodeFormat = NumericNotation.HEX;
        bool CompFontFlag = false;
        CompFontHelper CFHelper = null;
       
        List<int> CPs = new List<int>();
        int CP = 0;
        
        int UBN = 0;
        UnicodeBlock UB = null;
        int ScrPG = 0;                

        private void frmMain_Load(object sender, EventArgs e)
        {                     
            ttMain.SetToolTip(btnNext, "Next page (CTRL+N)");
            ttMain.SetToolTip(btnPrev, "Previous page (CTRL+P)");

            //создание контролов для таблицы            
            for (int i = 0; i< 256; i++)
            {                
                TableItems[i] = new TableItem();                
                TableItems[i].Name = "TableItem" + i.ToString();

                TableItems[i].Location = new Point(1, 1);
                TableItems[i].AutoSize = true;
                TableItems[i].Size = new System.Drawing.Size(51, 35);
                TableItems[i].TabIndex = i;                

                Controls.Add(TableItems[i]);
            }
            //TableItems[255].Resize += new EventHandler(LastItemResize);

            PosTableItems(StartX,StartY);

            //получение списка кодировок
            EncodingInfo[] ei = Encoding.GetEncodings();
            foreach (EncodingInfo einfo in ei)
            {
                int cp = einfo.CodePage;
                string name = einfo.Name;
                if ((Encoding.GetEncoding(cp).IsSingleByte) ||
                    (EncodingHelper.IsUnicode(cp)))
                {
                    CPs.Add(cp);
                    cmbCP.Items.Add(name);
                }
                
            }

            //получение блоков юникода
            if (!EncodingHelper.GetUnicodeBlocks(true, false)) //через сеть не получилось
            {                
                if (!EncodingHelper.GetUnicodeBlocks(false, false)) //вообще не получилось
                {
                    MessageBox.Show("GetUnicodeBlocks falied", "Error");
                }
            }
            
            if (EncodingHelper.UnicodeBlocks.Count != 0)
            {
                //заполнение combobox с блоками
                foreach (UnicodeBlock ub in EncodingHelper.UnicodeBlocks)
                {
                    cmbBlocks.Items.Add(ub.Desription + " ["
                        +ub.StartHex+".."+ub.EndHex+"]");
                }
                
                //установка начального блока и данных
                UBN = 0;
                UB = EncodingHelper.UnicodeBlocks[UBN];
                SetUnicLabelText();
            }

            //установка начальных значений
            CP = 1251;

            lblCPName.Text = Encoding.GetEncoding(CP).EncodingName
                + " [" + Encoding.GetEncoding(CP).CodePage.ToString() + "]";            

            FillTableOneByte();            
            PosTableItems(StartX, StartY);

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            
        }        
        

        private void PosTableItems(int BaseX, int BaseY)
        {

            
            //поиск максимальной высоты textbox'а с символом
            int MaxHeight = 0;
            for (int i = 0; i < 256; i++)
            {
                if (TableItems[i].ChrHeight > MaxHeight) MaxHeight = 
                    TableItems[i].ChrHeight;
            }

            if (EncodingHelper.IsUnicode(CP))
            {
                BaseY += AddY;
            }

            int NextX = BaseX; int NextY = BaseY;
            for (int i = 0; i < 256; i++)
            {
                TableItems[i].ChrHeight = MaxHeight; //выравниваем все по высоте
                TableItems[i].Location = new Point(NextX, NextY);
                if (((i + 1) % 16) == 0)
                {
                    NextY = NextY + TableItems[i + 1 - 16].Height;                        
                    NextX = BaseX;
                }
                else
                {
                    NextX = NextX + TableItems[i].Width;
                }
            }
        }

        private void FillTableOneByte()
        {
            Encoding enc = Encoding.GetEncoding(CP);
            for (int i = 0; i < 256; i++)
            {
                TableItems[i].Chr = enc.GetString(new byte[] { (byte)i });
                TableItems[i].CodeFormat = CodeFormat;
                TableItems[i].Code = i;                
            }
        }

        private void SetUnicLabelText()
        {
            lblBlock.Text = "[" + UB.StartHex + ".." +
                    UB.EndHex + "] " + "(" + UB.Length + " Page:" +ScrPG.ToString()+
                    "/"+UB.PagesCount(256)+")";
        }

        private bool FillUnicodeTable(int PageNumber)
        {
            int start = UB.PageStart(256, PageNumber);
            int end = UB.PageEnd(256, PageNumber);

            if ((start == -1) || (end == -1)) return false; //вылетели за кол-во страниц в блоке

            for (int i = 0; i < 256; i++)
            {
                int num = start + i;

                if (num <= end)
                {                                                             
                    string st = "";

                    if ((num >= 0x00d800) && (num <= 0x00dfff))
                    {
                        st = Convert.ToString((char)num);
                    }
                    else
                    {
                        st = char.ConvertFromUtf32(num);                        
                    }
                    
                    TableItems[i].Chr = st;
                    TableItems[i].CodeFormat = CodeFormat;
                    TableItems[i].Code = num;

                    if (CompFontFlag)
                    {
                        System.Drawing.Font cfont = CFHelper.GetFont(num);

                        if (cfont == null)
                        {
                            cfont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                        }
                        else
                        {
                            if (cfont != TableItems[i].SymFont)
                            {
                                TableItems[i].SymFont = cfont;
                                PosTableItems(StartX, StartY);
                            }
                        }
                    }
                }
                else
                {                    
                    TableItems[i].Clear();
                    //TableItems[i].ChrHeight = 13;
                }
            }
            return true;
        }

        //показывает или скрывает контролы для юникода
        private bool UCShowing = false;        
        private void UnicodeControls(bool show)
        {            
            if (show)
            {
                if (UCShowing) return; //чтоб не перерисовывать форму зря
                oldSize = this.Size;
                lblBlock.Visible = true;
                lblBlocks.Visible = true;
                btnPrev.Visible = true;
                btnNext.Visible = true;
                cmbBlocks.Visible = true;
                btnCompFont.Visible = true;

                PosTableItems(StartX, StartY);         
                
                UCShowing = true;
            }
            else
            {
                if (!UCShowing) return; //чтоб не перерисовывать форму зря
                lblBlock.Visible = false;
                lblBlocks.Visible = false;
                btnPrev.Visible = false;
                btnNext.Visible = false;
                cmbBlocks.Visible = false;
                btnCompFont.Visible = false;

                PosTableItems(StartX, StartY);                
                UCShowing = false;
            }
        }

        private void cmbCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CP = CPs[cmbCP.SelectedIndex];
            lblCPName.Text = Encoding.GetEncoding(CP).EncodingName + 
                " [" + CP.ToString() + "]";
            if (Encoding.GetEncoding(CP).IsSingleByte)
            {
                FillTableOneByte();
            }

            if (EncodingHelper.IsUnicode(CP))
            {
                lblCPName.Text = Encoding.GetEncoding(CP).EncodingName +
                    " [" + CP.ToString() + " Unicode" + "]";

                UnicodeControls(true);
                cmbBlocks_SelectedIndexChanged(null, null);
            }
            else
            {
                UnicodeControls(false);
            }
        }
        

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult Ans = DialogResult.OK;
            try
            {
                Ans = dlgFont.ShowDialog();
            }
            catch { }
            if (Ans == DialogResult.Cancel) return;

            for (int i = 0; i < 256; i++)
            {
                TableItems[i].SymFont = dlgFont.Font;                
            }

            PosTableItems(StartX, StartY);
            
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            CompFontFlag = false;
                        
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            this.AutoSize = !this.AutoSize;

            if (!this.AutoSize)
            {
                this.Size = new Size(638, 478);
                btnAutoSize.Text = "AutoSize Off";
                btnAutoSize.BackColor = SystemColors.Control;
            }
            else
            {
                btnAutoSize.Text = "AutoSize On";
                btnAutoSize.BackColor = Color.Yellow;
            }

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void btnEncodingsInfo_Click(object sender, EventArgs e)
        {
            frmEncInfo fEI = new frmEncInfo();
            fEI.ShowDialog();
        }

        private void cmbBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBlocks.Items.Count == 0) return;
            if (cmbBlocks.SelectedIndex == -1) cmbBlocks.SelectedIndex = 0;

            UBN = cmbBlocks.SelectedIndex;

            UB = EncodingHelper.UnicodeBlocks[UBN];            

            ScrPG = 0;
            FillUnicodeTable(ScrPG);
            SetUnicLabelText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ScrPG++;            
            if (!FillUnicodeTable(ScrPG))
            {
                //вылетели за границы блока
                //показываем следующий

                if (cmbBlocks.SelectedIndex == (cmbBlocks.Items.Count - 1))
                {
                    //показывали последний блок последнюю страницу
                    cmbBlocks.SelectedIndex = 0; //показываем 1 блок
                }
                else
                {
                    cmbBlocks.SelectedIndex++; //следующий блок
                }
            }
            SetUnicLabelText();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (EncodingHelper.IsUnicode(CP))
            {
                if (e.Control)
                {
                    if (e.KeyCode == Keys.N) btnNext.PerformClick();
                    if (e.KeyCode == Keys.P) btnPrev.PerformClick();
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ScrPG--;
            if (!FillUnicodeTable(ScrPG))
            {
                //вылетели за границы блока (в отрицательную сторону)
                //показываем предыдущий

                if (cmbBlocks.SelectedIndex == 0)
                {
                    //показывали 1 блок 1 страницу
                    return;
                }
                else
                {
                    cmbBlocks.SelectedIndex--; //предыдущий блок
                }
            }
            SetUnicLabelText();
        }

        private void btnFontFile_Click(object sender, EventArgs e)
        {
            if (!CompFontHelper.CheckFontFolder())
            {
                MessageBox.Show("Font directory " + CompFontHelper.FontFolder + " creating error",
                    "Error");
                return;
            }

            dlgOpen.InitialDirectory = CompFontHelper.FontFolder;
            dlgOpen.Filter = "TTF files|*.ttf";
            DialogResult Ans = dlgOpen.ShowDialog();
            if (Ans == DialogResult.Cancel) return;

            FileFont ff = new FileFont(dlgOpen.FileName);

            frmFontSettings fFontSettings = new frmFontSettings();
            fFontSettings.fileFont = ff;
            Ans = fFontSettings.ShowDialog();
            if (Ans == DialogResult.Cancel) return;
            ff = fFontSettings.fileFont;
            
            for (int i = 0; i < 256; i++)
            {
                TableItems[i].SymFont = ff.Font;
            }

            PosTableItems(StartX, StartY);            

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            CompFontFlag = false;
        }

        private void btnFontReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
            {
                TableItems[i].SetDefaultFont();
            }
            
            PosTableItems(StartX, StartY);
            
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            
        }

        private void btnCodeFormat_Click(object sender, EventArgs e)
        {
            switch (CodeFormat)
            {
                case NumericNotation.HEX:
                    {
                        CodeFormat = NumericNotation.DEC;
                    }; break;
                case NumericNotation.DEC:
                    {
                        CodeFormat = NumericNotation.OCT;
                    }; break;
                case NumericNotation.OCT:
                    {
                        CodeFormat = NumericNotation.HEX;
                    }; break;
            }

            btnCodeFormat.Text = Enum.GetName(typeof(NumericNotation), CodeFormat);

            for (int i = 0; i < 256; i++)
            {
                TableItems[i].CodeFormat = CodeFormat;
            }
        }

        private void btnCompFont_Click(object sender, EventArgs e)
        {
            frmCompFont fCompFont = new frmCompFont();
            fCompFont.CompFHelper=CFHelper;
            DialogResult Ans = fCompFont.ShowDialog();
            if (Ans == DialogResult.Cancel) return;
            CFHelper = fCompFont.CompFHelper;
            CompFontFlag = true;

            for (int i = 0; i < 256; i++)
            {
                int c = TableItems[i].Code;
                Font fnt = CFHelper.GetFont(c);
                TableItems[i].SymFont = fnt; ;
            }
            PosTableItems(StartX, StartY);

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }
        
    }

}
