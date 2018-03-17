namespace tmpCodeTable
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPName = new System.Windows.Forms.Label();
            this.cmbCP = new System.Windows.Forms.ComboBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.btnAutoSize = new System.Windows.Forms.Button();
            this.btnEncodingsInfo = new System.Windows.Forms.Button();
            this.cmbBlocks = new System.Windows.Forms.ComboBox();
            this.lblBlocks = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblBlock = new System.Windows.Forms.Label();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnFontFile = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnFontReset = new System.Windows.Forms.Button();
            this.btnCodeFormat = new System.Windows.Forms.Button();
            this.btnCompFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codepage";
            // 
            // lblCPName
            // 
            this.lblCPName.AutoSize = true;
            this.lblCPName.Location = new System.Drawing.Point(589, 11);
            this.lblCPName.Name = "lblCPName";
            this.lblCPName.Size = new System.Drawing.Size(13, 13);
            this.lblCPName.TabIndex = 2;
            this.lblCPName.Text = "0";
            // 
            // cmbCP
            // 
            this.cmbCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCP.FormattingEnabled = true;
            this.cmbCP.Location = new System.Drawing.Point(62, 7);
            this.cmbCP.Name = "cmbCP";
            this.cmbCP.Size = new System.Drawing.Size(121, 21);
            this.cmbCP.TabIndex = 4;
            this.cmbCP.SelectedIndexChanged += new System.EventHandler(this.cmbCP_SelectedIndexChanged);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(189, 6);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(37, 23);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnAutoSize
            // 
            this.btnAutoSize.BackColor = System.Drawing.Color.Yellow;
            this.btnAutoSize.Location = new System.Drawing.Point(368, 6);
            this.btnAutoSize.Name = "btnAutoSize";
            this.btnAutoSize.Size = new System.Drawing.Size(77, 23);
            this.btnAutoSize.TabIndex = 6;
            this.btnAutoSize.Text = "AutoSize On";
            this.btnAutoSize.UseVisualStyleBackColor = false;
            this.btnAutoSize.Click += new System.EventHandler(this.btnAutoSize_Click);
            // 
            // btnEncodingsInfo
            // 
            this.btnEncodingsInfo.Location = new System.Drawing.Point(451, 6);
            this.btnEncodingsInfo.Name = "btnEncodingsInfo";
            this.btnEncodingsInfo.Size = new System.Drawing.Size(87, 23);
            this.btnEncodingsInfo.TabIndex = 7;
            this.btnEncodingsInfo.Text = "Encodings Info";
            this.btnEncodingsInfo.UseVisualStyleBackColor = true;
            this.btnEncodingsInfo.Click += new System.EventHandler(this.btnEncodingsInfo_Click);
            // 
            // cmbBlocks
            // 
            this.cmbBlocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlocks.FormattingEnabled = true;
            this.cmbBlocks.Location = new System.Drawing.Point(38, 34);
            this.cmbBlocks.Name = "cmbBlocks";
            this.cmbBlocks.Size = new System.Drawing.Size(269, 21);
            this.cmbBlocks.TabIndex = 9;
            this.cmbBlocks.Visible = false;
            this.cmbBlocks.SelectedIndexChanged += new System.EventHandler(this.cmbBlocks_SelectedIndexChanged);
            // 
            // lblBlocks
            // 
            this.lblBlocks.AutoSize = true;
            this.lblBlocks.Location = new System.Drawing.Point(0, 37);
            this.lblBlocks.Name = "lblBlocks";
            this.lblBlocks.Size = new System.Drawing.Size(32, 13);
            this.lblBlocks.TabIndex = 8;
            this.lblBlocks.Text = "Chart";
            this.lblBlocks.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(408, 32);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(27, 23);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "<=";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(441, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "=>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(474, 37);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(13, 13);
            this.lblBlock.TabIndex = 12;
            this.lblBlock.Text = "0";
            this.lblBlock.Visible = false;
            // 
            // btnFontFile
            // 
            this.btnFontFile.Location = new System.Drawing.Point(232, 6);
            this.btnFontFile.Name = "btnFontFile";
            this.btnFontFile.Size = new System.Drawing.Size(60, 23);
            this.btnFontFile.TabIndex = 13;
            this.btnFontFile.Text = "Font file";
            this.btnFontFile.UseVisualStyleBackColor = true;
            this.btnFontFile.Click += new System.EventHandler(this.btnFontFile_Click);
            // 
            // btnFontReset
            // 
            this.btnFontReset.Location = new System.Drawing.Point(298, 6);
            this.btnFontReset.Name = "btnFontReset";
            this.btnFontReset.Size = new System.Drawing.Size(64, 23);
            this.btnFontReset.TabIndex = 14;
            this.btnFontReset.Text = "Font reset";
            this.btnFontReset.UseVisualStyleBackColor = true;
            this.btnFontReset.Click += new System.EventHandler(this.btnFontReset_Click);
            // 
            // btnCodeFormat
            // 
            this.btnCodeFormat.Location = new System.Drawing.Point(544, 6);
            this.btnCodeFormat.Name = "btnCodeFormat";
            this.btnCodeFormat.Size = new System.Drawing.Size(37, 23);
            this.btnCodeFormat.TabIndex = 15;
            this.btnCodeFormat.Text = "HEX";
            this.btnCodeFormat.UseVisualStyleBackColor = true;
            this.btnCodeFormat.Click += new System.EventHandler(this.btnCodeFormat_Click);
            // 
            // btnCompFont
            // 
            this.btnCompFont.Location = new System.Drawing.Point(313, 32);
            this.btnCompFont.Name = "btnCompFont";
            this.btnCompFont.Size = new System.Drawing.Size(89, 23);
            this.btnCompFont.TabIndex = 16;
            this.btnCompFont.Text = "Composite font";
            this.btnCompFont.UseVisualStyleBackColor = true;
            this.btnCompFont.Visible = false;
            this.btnCompFont.Click += new System.EventHandler(this.btnCompFont_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnCompFont);
            this.Controls.Add(this.btnCodeFormat);
            this.Controls.Add(this.btnFontReset);
            this.Controls.Add(this.btnFontFile);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.cmbBlocks);
            this.Controls.Add(this.lblBlocks);
            this.Controls.Add(this.btnEncodingsInfo);
            this.Controls.Add(this.btnAutoSize);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.cmbCP);
            this.Controls.Add(this.lblCPName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char table";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPName;
        private System.Windows.Forms.ComboBox cmbCP;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.Button btnAutoSize;
        private System.Windows.Forms.Button btnEncodingsInfo;
        private System.Windows.Forms.ComboBox cmbBlocks;
        private System.Windows.Forms.Label lblBlocks;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Button btnFontFile;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnFontReset;
        private System.Windows.Forms.Button btnCodeFormat;
        private System.Windows.Forms.Button btnCompFont;



    }
}

