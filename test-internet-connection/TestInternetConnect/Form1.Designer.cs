namespace TestInternetConnect
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
            this.components = new System.ComponentModel.Container();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnTestConfig = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.tmrStopping = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(1, 4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Net Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnStopTest
            // 
            this.btnStopTest.Location = new System.Drawing.Point(0, 86);
            this.btnStopTest.Name = "btnStopTest";
            this.btnStopTest.Size = new System.Drawing.Size(75, 23);
            this.btnStopTest.TabIndex = 1;
            this.btnStopTest.Text = "Stop Test";
            this.btnStopTest.UseVisualStyleBackColor = true;
            this.btnStopTest.Click += new System.EventHandler(this.btnStopTest_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(0, 59);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnTestConfig
            // 
            this.btnTestConfig.Location = new System.Drawing.Point(1, 31);
            this.btnTestConfig.Name = "btnTestConfig";
            this.btnTestConfig.Size = new System.Drawing.Size(75, 23);
            this.btnTestConfig.TabIndex = 3;
            this.btnTestConfig.Text = "Test Config";
            this.btnTestConfig.UseVisualStyleBackColor = true;
            this.btnTestConfig.Click += new System.EventHandler(this.btnTestConfig_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(82, 4);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(154, 131);
            this.pbProgress.TabIndex = 4;
            this.pbProgress.TabStop = false;
            this.pbProgress.Click += new System.EventHandler(this.pbProgress_Click);
            this.pbProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProgress_Paint);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(101, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Waiting command...";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new System.Drawing.Point(3, 113);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(66, 13);
            this.lblPause.TabIndex = 6;
            this.lblPause.Text = "PAUSE 99 s";
            // 
            // tmrStopping
            // 
            this.tmrStopping.Interval = 3000;
            this.tmrStopping.Tick += new System.EventHandler(this.tmrStopping_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 157);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnTestConfig);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.btnStopTest);
            this.Controls.Add(this.btnConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Internet Connection";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnStopTest;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnTestConfig;
        private System.Windows.Forms.PictureBox pbProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Timer tmrStopping;
    }
}

