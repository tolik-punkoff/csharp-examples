namespace HideCaret
{
    partial class frmHideCaret
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
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(1, 2);
            this.txtSampleText.Multiline = true;
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.ReadOnly = true;
            this.txtSampleText.Size = new System.Drawing.Size(332, 337);
            this.txtSampleText.TabIndex = 0;
            // 
            // frmHideCaret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 343);
            this.Controls.Add(this.txtSampleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHideCaret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Убрать курсор с помощью WinAPI";
            this.Load += new System.EventHandler(this.frmHideCaret_Load);
            this.Shown += new System.EventHandler(this.frmHideCaret_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSampleText;
    }
}