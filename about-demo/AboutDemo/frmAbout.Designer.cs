namespace AboutDemo
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnOK = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblProgName = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pctMessages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(159, 551);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = global::AboutDemo.Properties.Resources.logo;
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLogo.InitialImage = null;
            this.pctLogo.Location = new System.Drawing.Point(21, 30);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(388, 89);
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // lblProgName
            // 
            this.lblProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgName.Location = new System.Drawing.Point(16, 0);
            this.lblProgName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgName.Name = "lblProgName";
            this.lblProgName.Size = new System.Drawing.Size(407, 25);
            this.lblProgName.TabIndex = 2;
            this.lblProgName.Text = "About window demo";
            this.lblProgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCopyright.Location = new System.Drawing.Point(5, 521);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(423, 62);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "(L) Hex_Laden [Wildsoft], 2010-2018";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctMessages
            // 
            this.pctMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pctMessages.Location = new System.Drawing.Point(4, 129);
            this.pctMessages.Margin = new System.Windows.Forms.Padding(4);
            this.pctMessages.Name = "pctMessages";
            this.pctMessages.Size = new System.Drawing.Size(424, 393);
            this.pctMessages.TabIndex = 4;
            this.pctMessages.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 585);
            this.Controls.Add(this.pctMessages);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProgName);
            this.Controls.Add(this.pctLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblProgName;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox pctMessages;
    }
}

