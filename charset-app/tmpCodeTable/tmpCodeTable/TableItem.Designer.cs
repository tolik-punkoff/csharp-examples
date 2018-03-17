namespace tmpCodeTable
{
    partial class TableItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtChar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCode.Location = new System.Drawing.Point(3, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(45, 13);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChar
            // 
            this.txtChar.BackColor = System.Drawing.SystemColors.Window;
            this.txtChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChar.DetectUrls = false;
            this.txtChar.Location = new System.Drawing.Point(3, 19);
            this.txtChar.MaxLength = 1;
            this.txtChar.Multiline = false;
            this.txtChar.Name = "txtChar";
            this.txtChar.ReadOnly = true;
            this.txtChar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtChar.Size = new System.Drawing.Size(45, 13);
            this.txtChar.TabIndex = 1;
            this.txtChar.Text = "";
            this.txtChar.WordWrap = false;
            this.txtChar.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.txtChar_ContentsResized);
            // 
            // TableItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtChar);
            this.Name = "TableItem";
            this.Size = new System.Drawing.Size(51, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.RichTextBox txtChar;
    }
}
