namespace tmpReplaceTextIns
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
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblInsertMode = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(4, 50);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTest.Size = new System.Drawing.Size(289, 251);
            this.txtTest.TabIndex = 0;
            this.txtTest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTest_KeyUp);
            this.txtTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTest_KeyPress);
            // 
            // lblInsertMode
            // 
            this.lblInsertMode.AutoSize = true;
            this.lblInsertMode.Location = new System.Drawing.Point(46, 9);
            this.lblInsertMode.Name = "lblInsertMode";
            this.lblInsertMode.Size = new System.Drawing.Size(60, 13);
            this.lblInsertMode.TabIndex = 1;
            this.lblInsertMode.Text = "InsertMode";
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(113, 307);
            this.txtTest2.MaxLength = 4;
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 20);
            this.txtTest2.TabIndex = 2;
            this.txtTest2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTest_KeyUp);
            this.txtTest2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTest_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text max length == 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Multiline textbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert:";
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(113, 331);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(180, 20);
            this.txtTest3.TabIndex = 6;
            this.txtTest3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTest_KeyUp);
            this.txtTest3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTest_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Singleline textbox";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.lblInsertMode);
            this.Controls.Add(this.txtTest);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Replace text";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lblInsertMode;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Label label4;
    }
}

