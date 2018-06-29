namespace OverlayImages
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
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.pbTrizub = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbResize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrizub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFlag
            // 
            this.pbFlag.Location = new System.Drawing.Point(1, 4);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(320, 213);
            this.pbFlag.TabIndex = 0;
            this.pbFlag.TabStop = false;
            // 
            // pbTrizub
            // 
            this.pbTrizub.Location = new System.Drawing.Point(327, 4);
            this.pbTrizub.Name = "pbTrizub";
            this.pbTrizub.Size = new System.Drawing.Size(160, 121);
            this.pbTrizub.TabIndex = 1;
            this.pbTrizub.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(1, 223);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(198, 154);
            this.pbResult.TabIndex = 2;
            this.pbResult.TabStop = false;
            // 
            // pbResize
            // 
            this.pbResize.Location = new System.Drawing.Point(327, 223);
            this.pbResize.Name = "pbResize";
            this.pbResize.Size = new System.Drawing.Size(160, 74);
            this.pbResize.TabIndex = 3;
            this.pbResize.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 443);
            this.Controls.Add(this.pbResize);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbTrizub);
            this.Controls.Add(this.pbFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images Overlay Demo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrizub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.PictureBox pbTrizub;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbResize;
    }
}

