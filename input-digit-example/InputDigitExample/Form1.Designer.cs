namespace InputDigitExample
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
            this.lblDOnlyDigits = new System.Windows.Forms.Label();
            this.txtOnlyDigits = new System.Windows.Forms.TextBox();
            this.txtDigitsWithDots = new System.Windows.Forms.TextBox();
            this.lblDDigitsWithDots = new System.Windows.Forms.Label();
            this.txtDigitsWithDotsAndMinus = new System.Windows.Forms.TextBox();
            this.lblDDigitsWithDotsAndMinus = new System.Windows.Forms.Label();
            this.lblOnlyDigits = new System.Windows.Forms.Label();
            this.lblDigitsWithDots = new System.Windows.Forms.Label();
            this.lblDigitsWithDotsAndMinus = new System.Windows.Forms.Label();
            this.lblConvertStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDOnlyDigits
            // 
            this.lblDOnlyDigits.AutoSize = true;
            this.lblDOnlyDigits.Location = new System.Drawing.Point(13, 13);
            this.lblDOnlyDigits.Name = "lblDOnlyDigits";
            this.lblDOnlyDigits.Size = new System.Drawing.Size(58, 13);
            this.lblDOnlyDigits.TabIndex = 0;
            this.lblDOnlyDigits.Text = "Only digits:";
            // 
            // txtOnlyDigits
            // 
            this.txtOnlyDigits.Location = new System.Drawing.Point(169, 10);
            this.txtOnlyDigits.Name = "txtOnlyDigits";
            this.txtOnlyDigits.Size = new System.Drawing.Size(280, 20);
            this.txtOnlyDigits.TabIndex = 1;
            this.txtOnlyDigits.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtOnlyDigits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyDigits_KeyPress);
            // 
            // txtDigitsWithDots
            // 
            this.txtDigitsWithDots.Location = new System.Drawing.Point(169, 36);
            this.txtDigitsWithDots.Name = "txtDigitsWithDots";
            this.txtDigitsWithDots.Size = new System.Drawing.Size(280, 20);
            this.txtDigitsWithDots.TabIndex = 3;
            this.txtDigitsWithDots.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDigitsWithDots.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigitsWithDots_KeyPress);
            // 
            // lblDDigitsWithDots
            // 
            this.lblDDigitsWithDots.AutoSize = true;
            this.lblDDigitsWithDots.Location = new System.Drawing.Point(13, 39);
            this.lblDDigitsWithDots.Name = "lblDDigitsWithDots";
            this.lblDDigitsWithDots.Size = new System.Drawing.Size(76, 13);
            this.lblDDigitsWithDots.TabIndex = 2;
            this.lblDDigitsWithDots.Text = "Float numbers:";
            // 
            // txtDigitsWithDotsAndMinus
            // 
            this.txtDigitsWithDotsAndMinus.Location = new System.Drawing.Point(169, 62);
            this.txtDigitsWithDotsAndMinus.Name = "txtDigitsWithDotsAndMinus";
            this.txtDigitsWithDotsAndMinus.Size = new System.Drawing.Size(280, 20);
            this.txtDigitsWithDotsAndMinus.TabIndex = 5;
            this.txtDigitsWithDotsAndMinus.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDigitsWithDotsAndMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigitsWithDotsAndMinus_KeyPress);
            // 
            // lblDDigitsWithDotsAndMinus
            // 
            this.lblDDigitsWithDotsAndMinus.AutoSize = true;
            this.lblDDigitsWithDotsAndMinus.Location = new System.Drawing.Point(13, 65);
            this.lblDDigitsWithDotsAndMinus.Name = "lblDDigitsWithDotsAndMinus";
            this.lblDDigitsWithDotsAndMinus.Size = new System.Drawing.Size(150, 13);
            this.lblDDigitsWithDotsAndMinus.TabIndex = 4;
            this.lblDDigitsWithDotsAndMinus.Text = "Float numbers with minus sign:";
            // 
            // lblOnlyDigits
            // 
            this.lblOnlyDigits.AutoSize = true;
            this.lblOnlyDigits.Location = new System.Drawing.Point(455, 13);
            this.lblOnlyDigits.Name = "lblOnlyDigits";
            this.lblOnlyDigits.Size = new System.Drawing.Size(35, 13);
            this.lblOnlyDigits.TabIndex = 6;
            this.lblOnlyDigits.Text = "label4";
            // 
            // lblDigitsWithDots
            // 
            this.lblDigitsWithDots.AutoSize = true;
            this.lblDigitsWithDots.Location = new System.Drawing.Point(455, 39);
            this.lblDigitsWithDots.Name = "lblDigitsWithDots";
            this.lblDigitsWithDots.Size = new System.Drawing.Size(35, 13);
            this.lblDigitsWithDots.TabIndex = 7;
            this.lblDigitsWithDots.Text = "label4";
            // 
            // lblDigitsWithDotsAndMinus
            // 
            this.lblDigitsWithDotsAndMinus.AutoSize = true;
            this.lblDigitsWithDotsAndMinus.Location = new System.Drawing.Point(455, 65);
            this.lblDigitsWithDotsAndMinus.Name = "lblDigitsWithDotsAndMinus";
            this.lblDigitsWithDotsAndMinus.Size = new System.Drawing.Size(35, 13);
            this.lblDigitsWithDotsAndMinus.TabIndex = 8;
            this.lblDigitsWithDotsAndMinus.Text = "label4";
            // 
            // lblConvertStatus
            // 
            this.lblConvertStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConvertStatus.Location = new System.Drawing.Point(16, 91);
            this.lblConvertStatus.Name = "lblConvertStatus";
            this.lblConvertStatus.Size = new System.Drawing.Size(608, 23);
            this.lblConvertStatus.TabIndex = 9;
            this.lblConvertStatus.Text = "Convert status";
            this.lblConvertStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 116);
            this.Controls.Add(this.lblConvertStatus);
            this.Controls.Add(this.lblDigitsWithDotsAndMinus);
            this.Controls.Add(this.lblDigitsWithDots);
            this.Controls.Add(this.lblOnlyDigits);
            this.Controls.Add(this.txtDigitsWithDotsAndMinus);
            this.Controls.Add(this.lblDDigitsWithDotsAndMinus);
            this.Controls.Add(this.txtDigitsWithDots);
            this.Controls.Add(this.lblDDigitsWithDots);
            this.Controls.Add(this.txtOnlyDigits);
            this.Controls.Add(this.lblDOnlyDigits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Digit Example";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDOnlyDigits;
        private System.Windows.Forms.TextBox txtOnlyDigits;
        private System.Windows.Forms.TextBox txtDigitsWithDots;
        private System.Windows.Forms.Label lblDDigitsWithDots;
        private System.Windows.Forms.TextBox txtDigitsWithDotsAndMinus;
        private System.Windows.Forms.Label lblDDigitsWithDotsAndMinus;
        private System.Windows.Forms.Label lblOnlyDigits;
        private System.Windows.Forms.Label lblDigitsWithDots;
        private System.Windows.Forms.Label lblDigitsWithDotsAndMinus;
        private System.Windows.Forms.Label lblConvertStatus;
    }
}

