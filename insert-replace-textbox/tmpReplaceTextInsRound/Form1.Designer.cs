namespace tmpReplaceTextInsRound
{
    partial class frmTest
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblInsertMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insert:";
            // 
            // lblInsertMode
            // 
            this.lblInsertMode.AutoSize = true;
            this.lblInsertMode.Location = new System.Drawing.Point(43, 9);
            this.lblInsertMode.Name = "lblInsertMode";
            this.lblInsertMode.Size = new System.Drawing.Size(60, 13);
            this.lblInsertMode.TabIndex = 6;
            this.lblInsertMode.Text = "InsertMode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text max length == 4";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(114, 28);
            this.txtTest.MaxLength = 4;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 20);
            this.txtTest.TabIndex = 8;
            this.txtTest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTest_KeyUp);
            this.txtTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTest_KeyPress);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 68);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInsertMode);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text replace test";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInsertMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest;
    }
}

