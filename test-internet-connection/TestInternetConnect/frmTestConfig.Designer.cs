namespace TestInternetConnect
{
    partial class frmTestConfig
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
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPause = new System.Windows.Forms.TextBox();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(3, 4);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(41, 1);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(218, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://microsoft.com";
            // 
            // txtPause
            // 
            this.txtPause.Location = new System.Drawing.Point(167, 27);
            this.txtPause.MaxLength = 2;
            this.txtPause.Name = "txtPause";
            this.txtPause.Size = new System.Drawing.Size(92, 20);
            this.txtPause.TabIndex = 3;
            this.txtPause.Text = "0";
            this.txtPause.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPause_KeyPress);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new System.Drawing.Point(3, 30);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(166, 13);
            this.lblPause.TabIndex = 2;
            this.lblPause.Text = "Пауза между соединениями, с:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 58);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmTestConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 85);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPause);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTestConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Config";
            this.Load += new System.EventHandler(this.frmTestConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}