namespace TestOpenForm
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
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormOpened = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(23, 36);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(83, 23);
            this.btnOpenForm.TabIndex = 0;
            this.btnOpenForm.Text = "Open Form #2";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form #1";
            // 
            // lblFormOpened
            // 
            this.lblFormOpened.AutoSize = true;
            this.lblFormOpened.ForeColor = System.Drawing.Color.Red;
            this.lblFormOpened.Location = new System.Drawing.Point(3, 64);
            this.lblFormOpened.Name = "lblFormOpened";
            this.lblFormOpened.Size = new System.Drawing.Size(0, 13);
            this.lblFormOpened.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 80);
            this.Controls.Add(this.lblFormOpened);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFormOpened;
    }
}

