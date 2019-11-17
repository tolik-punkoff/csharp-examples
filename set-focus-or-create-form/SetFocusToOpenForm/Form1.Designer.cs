namespace SetFocusToOpenForm
{
    partial class frmParent
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
            this.btnChild1 = new System.Windows.Forms.Button();
            this.btnChild2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChild1
            // 
            this.btnChild1.Location = new System.Drawing.Point(12, 12);
            this.btnChild1.Name = "btnChild1";
            this.btnChild1.Size = new System.Drawing.Size(75, 23);
            this.btnChild1.TabIndex = 0;
            this.btnChild1.Text = "Child #1";
            this.btnChild1.UseVisualStyleBackColor = true;
            this.btnChild1.Click += new System.EventHandler(this.btnChild1_Click);
            // 
            // btnChild2
            // 
            this.btnChild2.Location = new System.Drawing.Point(93, 12);
            this.btnChild2.Name = "btnChild2";
            this.btnChild2.Size = new System.Drawing.Size(75, 23);
            this.btnChild2.TabIndex = 1;
            this.btnChild2.Text = "Child #2";
            this.btnChild2.UseVisualStyleBackColor = true;
            this.btnChild2.Click += new System.EventHandler(this.btnChild2_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 46);
            this.Controls.Add(this.btnChild2);
            this.Controls.Add(this.btnChild1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChild1;
        private System.Windows.Forms.Button btnChild2;
    }
}

