namespace tmpBinOctHexDec
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
            this.lblBIN = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtOct = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.lblChr = new System.Windows.Forms.Label();
            this.txtChr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncID = new System.Windows.Forms.TextBox();
            this.lblEncName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBIN
            // 
            this.lblBIN.AutoSize = true;
            this.lblBIN.Location = new System.Drawing.Point(4, 13);
            this.lblBIN.Name = "lblBIN";
            this.lblBIN.Size = new System.Drawing.Size(25, 13);
            this.lblBIN.TabIndex = 0;
            this.lblBIN.Text = "BIN";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Location = new System.Drawing.Point(4, 40);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(29, 13);
            this.lblOct.TabIndex = 1;
            this.lblOct.Text = "OCT";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(4, 67);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(29, 13);
            this.lblHex.TabIndex = 2;
            this.lblHex.Text = "HEX";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(4, 95);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(29, 13);
            this.lblDec.TabIndex = 3;
            this.lblDec.Text = "DEC";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(45, 10);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(452, 20);
            this.txtBin.TabIndex = 4;
            this.txtBin.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin_KeyPress);
            // 
            // txtOct
            // 
            this.txtOct.Location = new System.Drawing.Point(45, 37);
            this.txtOct.Name = "txtOct";
            this.txtOct.Size = new System.Drawing.Size(452, 20);
            this.txtOct.TabIndex = 5;
            this.txtOct.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtOct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOct_KeyPress);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(45, 64);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(452, 20);
            this.txtHex.TabIndex = 6;
            this.txtHex.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(45, 92);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(452, 20);
            this.txtDec.TabIndex = 7;
            this.txtDec.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDec_KeyPress);
            // 
            // lblChr
            // 
            this.lblChr.AutoSize = true;
            this.lblChr.Location = new System.Drawing.Point(4, 124);
            this.lblChr.Name = "lblChr";
            this.lblChr.Size = new System.Drawing.Size(30, 13);
            this.lblChr.TabIndex = 8;
            this.lblChr.Text = "CHR";
            // 
            // txtChr
            // 
            this.txtChr.Location = new System.Drawing.Point(45, 121);
            this.txtChr.Name = "txtChr";
            this.txtChr.ReadOnly = true;
            this.txtChr.Size = new System.Drawing.Size(452, 20);
            this.txtChr.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Encoding";
            // 
            // txtEncID
            // 
            this.txtEncID.Location = new System.Drawing.Point(61, 149);
            this.txtEncID.Name = "txtEncID";
            this.txtEncID.Size = new System.Drawing.Size(73, 20);
            this.txtEncID.TabIndex = 11;
            this.txtEncID.TextChanged += new System.EventHandler(this.txtEncID_TextChanged);
            this.txtEncID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEncID_KeyPress);
            // 
            // lblEncName
            // 
            this.lblEncName.AutoSize = true;
            this.lblEncName.Location = new System.Drawing.Point(140, 152);
            this.lblEncName.Name = "lblEncName";
            this.lblEncName.Size = new System.Drawing.Size(56, 13);
            this.lblEncName.TabIndex = 12;
            this.lblEncName.Text = "(Default 0)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 178);
            this.Controls.Add(this.lblEncName);
            this.Controls.Add(this.txtEncID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChr);
            this.Controls.Add(this.lblChr);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtOct);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblOct);
            this.Controls.Add(this.lblBIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bin/Oct/Hex/Dec";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBIN;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtOct;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Label lblChr;
        private System.Windows.Forms.TextBox txtChr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncID;
        private System.Windows.Forms.Label lblEncName;
    }
}

