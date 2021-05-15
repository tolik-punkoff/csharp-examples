namespace KeyTest
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvLog = new KeyTest.MyListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.chkKeyUp = new System.Windows.Forms.CheckBox();
            this.chkKeyDown = new System.Windows.Forms.CheckBox();
            this.chkKeyPress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(3, 12);
            this.txtTest.Name = "txtTest";
            this.txtTest.ReadOnly = true;
            this.txtTest.Size = new System.Drawing.Size(548, 20);
            this.txtTest.TabIndex = 0;
            this.txtTest.Text = "Вставьте курсор в это поле и нажмите клавишу или комбинацию клавиш";
            this.txtTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTest_KeyDown);
            this.txtTest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTest_KeyUp);
            this.txtTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTest_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvLog
            // 
            this.lvLog.BackColor = System.Drawing.Color.Black;
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lvLog.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvLog.Location = new System.Drawing.Point(3, 38);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(548, 452);
            this.lvLog.TabIndex = 1;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Лог";
            this.columnHeader1.Width = 544;
            // 
            // chkKeyUp
            // 
            this.chkKeyUp.AutoSize = true;
            this.chkKeyUp.Checked = true;
            this.chkKeyUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeyUp.Location = new System.Drawing.Point(84, 500);
            this.chkKeyUp.Name = "chkKeyUp";
            this.chkKeyUp.Size = new System.Drawing.Size(58, 17);
            this.chkKeyUp.TabIndex = 3;
            this.chkKeyUp.Text = "KeyUp";
            this.chkKeyUp.UseVisualStyleBackColor = true;
            // 
            // chkKeyDown
            // 
            this.chkKeyDown.AutoSize = true;
            this.chkKeyDown.Location = new System.Drawing.Point(148, 500);
            this.chkKeyDown.Name = "chkKeyDown";
            this.chkKeyDown.Size = new System.Drawing.Size(72, 17);
            this.chkKeyDown.TabIndex = 4;
            this.chkKeyDown.Text = "KeyDown";
            this.chkKeyDown.UseVisualStyleBackColor = true;
            // 
            // chkKeyPress
            // 
            this.chkKeyPress.AutoSize = true;
            this.chkKeyPress.Location = new System.Drawing.Point(226, 500);
            this.chkKeyPress.Name = "chkKeyPress";
            this.chkKeyPress.Size = new System.Drawing.Size(70, 17);
            this.chkKeyPress.TabIndex = 5;
            this.chkKeyPress.Text = "KeyPress";
            this.chkKeyPress.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 523);
            this.Controls.Add(this.chkKeyPress);
            this.Controls.Add(this.chkKeyDown);
            this.Controls.Add(this.chkKeyUp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.txtTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест клавиш";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTest;
        private MyListView lvLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkKeyUp;
        private System.Windows.Forms.CheckBox chkKeyDown;
        private System.Windows.Forms.CheckBox chkKeyPress;
    }
}

