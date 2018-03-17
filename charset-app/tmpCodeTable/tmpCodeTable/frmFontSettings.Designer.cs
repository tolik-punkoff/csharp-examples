namespace tmpCodeTable
{
    partial class frmFontSettings
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
            this.lblFont = new System.Windows.Forms.Label();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnRegular = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFont.Location = new System.Drawing.Point(140, 29);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(30, 15);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFont.Resize += new System.EventHandler(this.lblFont_Resize);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(0, 1);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(47, 17);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(52, 1);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(48, 17);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(256, 0);
            this.numSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(47, 20);
            this.numSize.TabIndex = 3;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(106, 1);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(71, 17);
            this.chkUnderline.TabIndex = 4;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Location = new System.Drawing.Point(179, 1);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(68, 17);
            this.chkStrikeout.TabIndex = 5;
            this.chkStrikeout.Text = "Strikeout";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            this.chkStrikeout.CheckedChanged += new System.EventHandler(this.chkStrikeout_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOK.Location = new System.Drawing.Point(0, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(299, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnRegular);
            this.pnlControls.Controls.Add(this.numSize);
            this.pnlControls.Controls.Add(this.chkBold);
            this.pnlControls.Controls.Add(this.chkItalic);
            this.pnlControls.Controls.Add(this.chkStrikeout);
            this.pnlControls.Controls.Add(this.chkUnderline);
            this.pnlControls.Location = new System.Drawing.Point(3, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(370, 24);
            this.pnlControls.TabIndex = 8;
            // 
            // btnRegular
            // 
            this.btnRegular.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegular.Location = new System.Drawing.Point(312, 0);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(58, 24);
            this.btnRegular.TabIndex = 10;
            this.btnRegular.Text = "Regular";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 50);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(374, 28);
            this.pnlButtons.TabIndex = 9;
            // 
            // frmFontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 78);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFontSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font settings";
            this.Load += new System.EventHandler(this.frmFontSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnRegular;
    }
}