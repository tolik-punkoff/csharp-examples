namespace tmpCodeTable
{
    partial class frmEncInfo
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
            this.grdEncodings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncodings)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEncodings
            // 
            this.grdEncodings.AllowUserToAddRows = false;
            this.grdEncodings.AllowUserToDeleteRows = false;
            this.grdEncodings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEncodings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEncodings.Location = new System.Drawing.Point(0, 0);
            this.grdEncodings.Name = "grdEncodings";
            this.grdEncodings.ReadOnly = true;
            this.grdEncodings.Size = new System.Drawing.Size(630, 451);
            this.grdEncodings.TabIndex = 1;
            // 
            // frmEncInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 451);
            this.Controls.Add(this.grdEncodings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEncInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encodings Info";
            this.Load += new System.EventHandler(this.frmEncInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEncodings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEncodings;
    }
}