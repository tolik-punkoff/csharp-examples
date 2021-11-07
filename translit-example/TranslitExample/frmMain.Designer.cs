namespace TranslitExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestString = new System.Windows.Forms.TextBox();
            this.txtTranslit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCompMode = new System.Windows.Forms.CheckBox();
            this.lblIsCyr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строка:";
            // 
            // txtTestString
            // 
            this.txtTestString.Location = new System.Drawing.Point(62, 10);
            this.txtTestString.Name = "txtTestString";
            this.txtTestString.Size = new System.Drawing.Size(533, 20);
            this.txtTestString.TabIndex = 1;
            this.txtTestString.TextChanged += new System.EventHandler(this.txtTestString_TextChanged);
            // 
            // txtTranslit
            // 
            this.txtTranslit.Location = new System.Drawing.Point(62, 36);
            this.txtTranslit.Name = "txtTranslit";
            this.txtTranslit.ReadOnly = true;
            this.txtTranslit.Size = new System.Drawing.Size(533, 20);
            this.txtTranslit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Транслит:";
            // 
            // chkCompMode
            // 
            this.chkCompMode.AutoSize = true;
            this.chkCompMode.Location = new System.Drawing.Point(7, 62);
            this.chkCompMode.Name = "chkCompMode";
            this.chkCompMode.Size = new System.Drawing.Size(319, 17);
            this.chkCompMode.TabIndex = 4;
            this.chkCompMode.Text = "Режим совместимости (заменяет пробел, Ъ, Ь на знак _)";
            this.chkCompMode.UseVisualStyleBackColor = true;
            this.chkCompMode.CheckedChanged += new System.EventHandler(this.chkCompMode_CheckedChanged);
            // 
            // lblIsCyr
            // 
            this.lblIsCyr.AutoSize = true;
            this.lblIsCyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsCyr.Location = new System.Drawing.Point(330, 64);
            this.lblIsCyr.Name = "lblIsCyr";
            this.lblIsCyr.Size = new System.Drawing.Size(47, 15);
            this.lblIsCyr.TabIndex = 5;
            this.lblIsCyr.Text = "label3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 87);
            this.Controls.Add(this.lblIsCyr);
            this.Controls.Add(this.chkCompMode);
            this.Controls.Add(this.txtTranslit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTestString);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translit Example";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestString;
        private System.Windows.Forms.TextBox txtTranslit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCompMode;
        private System.Windows.Forms.Label lblIsCyr;
    }
}

