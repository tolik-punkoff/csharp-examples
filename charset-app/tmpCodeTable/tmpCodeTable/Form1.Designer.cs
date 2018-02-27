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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPName = new System.Windows.Forms.Label();
            this.cmbCP = new System.Windows.Forms.ComboBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.btnAutoSize = new System.Windows.Forms.Button();
            this.btnEncodingsInfo = new System.Windows.Forms.Button();
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
            this.lblCPName.Location = new System.Drawing.Point(408, 10);
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
            this.btnFont.Location = new System.Drawing.Point(189, 5);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(37, 23);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnAutoSize
            // 
            this.btnAutoSize.Location = new System.Drawing.Point(232, 5);
            this.btnAutoSize.Name = "btnAutoSize";
            this.btnAutoSize.Size = new System.Drawing.Size(77, 23);
            this.btnAutoSize.TabIndex = 6;
            this.btnAutoSize.Text = "AutoSize Off";
            this.btnAutoSize.UseVisualStyleBackColor = true;
            this.btnAutoSize.Click += new System.EventHandler(this.btnAutoSize_Click);
            // 
            // btnEncodingsInfo
            // 
            this.btnEncodingsInfo.Location = new System.Drawing.Point(315, 5);
            this.btnEncodingsInfo.Name = "btnEncodingsInfo";
            this.btnEncodingsInfo.Size = new System.Drawing.Size(87, 23);
            this.btnEncodingsInfo.TabIndex = 7;
            this.btnEncodingsInfo.Text = "Encodings Info";
            this.btnEncodingsInfo.UseVisualStyleBackColor = true;
            this.btnEncodingsInfo.Click += new System.EventHandler(this.btnEncodingsInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnEncodingsInfo);
            this.Controls.Add(this.btnAutoSize);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.cmbCP);
            this.Controls.Add(this.lblCPName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char table";
            this.Load += new System.EventHandler(this.frmMain_Load);
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



    }
}

