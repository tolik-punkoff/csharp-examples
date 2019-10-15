namespace HideCaret
{
    partial class frmDemo
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
            this.btnCaretInStart = new System.Windows.Forms.Button();
            this.btnCaretToEnd = new System.Windows.Forms.Button();
            this.btnChangeFocus = new System.Windows.Forms.Button();
            this.btnHideCaret = new System.Windows.Forms.Button();
            this.btnSimpleText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaretInStart
            // 
            this.btnCaretInStart.Location = new System.Drawing.Point(2, 12);
            this.btnCaretInStart.Name = "btnCaretInStart";
            this.btnCaretInStart.Size = new System.Drawing.Size(217, 23);
            this.btnCaretInStart.TabIndex = 0;
            this.btnCaretInStart.Text = "Курсор в начало текста";
            this.btnCaretInStart.UseVisualStyleBackColor = true;
            this.btnCaretInStart.Click += new System.EventHandler(this.btnCaretInStart_Click);
            // 
            // btnCaretToEnd
            // 
            this.btnCaretToEnd.Location = new System.Drawing.Point(3, 41);
            this.btnCaretToEnd.Name = "btnCaretToEnd";
            this.btnCaretToEnd.Size = new System.Drawing.Size(217, 23);
            this.btnCaretToEnd.TabIndex = 1;
            this.btnCaretToEnd.Text = "Курсор в конец текста";
            this.btnCaretToEnd.UseVisualStyleBackColor = true;
            this.btnCaretToEnd.Click += new System.EventHandler(this.btnCaretToEnd_Click);
            // 
            // btnChangeFocus
            // 
            this.btnChangeFocus.Location = new System.Drawing.Point(2, 70);
            this.btnChangeFocus.Name = "btnChangeFocus";
            this.btnChangeFocus.Size = new System.Drawing.Size(217, 23);
            this.btnChangeFocus.TabIndex = 2;
            this.btnChangeFocus.Text = "Убрать курсор (смена фокуса)";
            this.btnChangeFocus.UseVisualStyleBackColor = true;
            this.btnChangeFocus.Click += new System.EventHandler(this.btnChangeFocus_Click);
            // 
            // btnHideCaret
            // 
            this.btnHideCaret.Location = new System.Drawing.Point(3, 99);
            this.btnHideCaret.Name = "btnHideCaret";
            this.btnHideCaret.Size = new System.Drawing.Size(217, 23);
            this.btnHideCaret.TabIndex = 3;
            this.btnHideCaret.Text = "Убрать курсор (WIN API)";
            this.btnHideCaret.UseVisualStyleBackColor = true;
            this.btnHideCaret.Click += new System.EventHandler(this.btnHideCaret_Click);
            // 
            // btnSimpleText
            // 
            this.btnSimpleText.Location = new System.Drawing.Point(3, 128);
            this.btnSimpleText.Name = "btnSimpleText";
            this.btnSimpleText.Size = new System.Drawing.Size(217, 23);
            this.btnSimpleText.TabIndex = 4;
            this.btnSimpleText.Text = "Простой текст (будет выделен)";
            this.btnSimpleText.UseVisualStyleBackColor = true;
            this.btnSimpleText.Click += new System.EventHandler(this.btnSimpleText_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 154);
            this.Controls.Add(this.btnSimpleText);
            this.Controls.Add(this.btnHideCaret);
            this.Controls.Add(this.btnChangeFocus);
            this.Controls.Add(this.btnCaretToEnd);
            this.Controls.Add(this.btnCaretInStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaretInStart;
        private System.Windows.Forms.Button btnCaretToEnd;
        private System.Windows.Forms.Button btnChangeFocus;
        private System.Windows.Forms.Button btnHideCaret;
        private System.Windows.Forms.Button btnSimpleText;
    }
}

