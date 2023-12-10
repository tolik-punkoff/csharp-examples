namespace CKFConverter
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
            this.lblC = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.idcF = new Wildsoft.Controls.InputDigitControl();
            this.idcK = new Wildsoft.Controls.InputDigitControl();
            this.idcC = new Wildsoft.Controls.InputDigitControl();
            this.SuspendLayout();
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(4, 7);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(18, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C°";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(4, 31);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(14, 13);
            this.lblK.TabIndex = 4;
            this.lblK.Text = "K";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(3, 55);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(17, 13);
            this.lblF.TabIndex = 6;
            this.lblF.Text = "F°";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Black;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Lime;
            this.lblError.Location = new System.Drawing.Point(24, 74);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(290, 21);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idcF
            // 
            this.idcF.Fractional = true;
            this.idcF.Location = new System.Drawing.Point(24, 51);
            this.idcF.Name = "idcF";
            this.idcF.Negative = true;
            this.idcF.Size = new System.Drawing.Size(290, 20);
            this.idcF.TabIndex = 5;
            this.idcF.TextChanged += new System.EventHandler(this.idc_Changed);
            this.idcF.Enter += new System.EventHandler(this.idc_Enter);
            // 
            // idcK
            // 
            this.idcK.Fractional = true;
            this.idcK.Location = new System.Drawing.Point(25, 27);
            this.idcK.Name = "idcK";
            this.idcK.Size = new System.Drawing.Size(290, 20);
            this.idcK.TabIndex = 3;
            this.idcK.TextChanged += new System.EventHandler(this.idc_Changed);
            this.idcK.Enter += new System.EventHandler(this.idc_Enter);
            // 
            // idcC
            // 
            this.idcC.Fractional = true;
            this.idcC.Location = new System.Drawing.Point(26, 3);
            this.idcC.Name = "idcC";
            this.idcC.Negative = true;
            this.idcC.Size = new System.Drawing.Size(290, 20);
            this.idcC.TabIndex = 1;
            this.idcC.TextChanged += new System.EventHandler(this.idc_Changed);
            this.idcC.Enter += new System.EventHandler(this.idc_Enter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 96);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.idcF);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.idcK);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.idcC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер температур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wildsoft.Controls.InputDigitControl idcC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblK;
        private Wildsoft.Controls.InputDigitControl idcK;
        private System.Windows.Forms.Label lblF;
        private Wildsoft.Controls.InputDigitControl idcF;
        private System.Windows.Forms.Label lblError;

    }
}

