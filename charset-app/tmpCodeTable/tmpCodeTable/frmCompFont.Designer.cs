namespace tmpCodeTable
{
    partial class frmCompFont
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
            this.grdCompFont = new System.Windows.Forms.DataGridView();
            this.clStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFontOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompFont)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCompFont
            // 
            this.grdCompFont.AllowUserToAddRows = false;
            this.grdCompFont.AllowUserToDeleteRows = false;
            this.grdCompFont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompFont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStart,
            this.clEnd,
            this.clFont,
            this.clFile,
            this.clFontOptions});
            this.grdCompFont.Location = new System.Drawing.Point(3, 2);
            this.grdCompFont.Name = "grdCompFont";
            this.grdCompFont.ReadOnly = true;
            this.grdCompFont.Size = new System.Drawing.Size(580, 399);
            this.grdCompFont.TabIndex = 0;
            this.grdCompFont.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCompFont_CellDoubleClick);
            this.grdCompFont.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdCompFont_CellFormatting);
            // 
            // clStart
            // 
            this.clStart.HeaderText = "Start";
            this.clStart.Name = "clStart";
            this.clStart.ReadOnly = true;
            // 
            // clEnd
            // 
            this.clEnd.HeaderText = "End";
            this.clEnd.Name = "clEnd";
            this.clEnd.ReadOnly = true;
            // 
            // clFont
            // 
            this.clFont.HeaderText = "Font";
            this.clFont.Name = "clFont";
            this.clFont.ReadOnly = true;
            // 
            // clFile
            // 
            this.clFile.HeaderText = "File";
            this.clFile.Name = "clFile";
            this.clFile.ReadOnly = true;
            // 
            // clFontOptions
            // 
            this.clFontOptions.HeaderText = "Font options";
            this.clFontOptions.Name = "clFontOptions";
            this.clFontOptions.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(588, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(588, 41);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(43, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(589, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(588, 148);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(43, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 420);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(0, 404);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(460, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "DEL - Clear value, Ctrl+E, Double click - Edit value, Ctrl+Ins - Insert string, C" +
                "trl+Del - Delete string";
            // 
            // frmCompFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 445);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdCompFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompFont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Composite font";
            this.Load += new System.EventHandler(this.frmCompFont_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCompFont_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompFont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCompFont;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFont;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFontOptions;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}