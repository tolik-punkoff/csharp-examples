namespace IconOverlay
{
    partial class frmTest
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
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.pbOverlay = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btnShowIcon = new System.Windows.Forms.Button();
            this.niTest = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHideIcon = new System.Windows.Forms.Button();
            this.btnMainIcon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTarget
            // 
            this.pbTarget.Location = new System.Drawing.Point(41, 3);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(16, 16);
            this.pbTarget.TabIndex = 0;
            this.pbTarget.TabStop = false;
            // 
            // pbOverlay
            // 
            this.pbOverlay.Location = new System.Drawing.Point(70, 3);
            this.pbOverlay.Name = "pbOverlay";
            this.pbOverlay.Size = new System.Drawing.Size(16, 16);
            this.pbOverlay.TabIndex = 1;
            this.pbOverlay.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(100, 3);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(16, 16);
            this.pbResult.TabIndex = 2;
            this.pbResult.TabStop = false;
            // 
            // btnShowIcon
            // 
            this.btnShowIcon.Location = new System.Drawing.Point(4, 25);
            this.btnShowIcon.Name = "btnShowIcon";
            this.btnShowIcon.Size = new System.Drawing.Size(75, 23);
            this.btnShowIcon.TabIndex = 3;
            this.btnShowIcon.Text = "Show icon";
            this.btnShowIcon.UseVisualStyleBackColor = true;
            this.btnShowIcon.Click += new System.EventHandler(this.btnShowIcon_Click);
            // 
            // niTest
            // 
            this.niTest.Text = "notifyIcon1";
            this.niTest.Visible = true;
            // 
            // btnHideIcon
            // 
            this.btnHideIcon.Location = new System.Drawing.Point(85, 25);
            this.btnHideIcon.Name = "btnHideIcon";
            this.btnHideIcon.Size = new System.Drawing.Size(75, 23);
            this.btnHideIcon.TabIndex = 4;
            this.btnHideIcon.Text = "Hide icon";
            this.btnHideIcon.UseVisualStyleBackColor = true;
            this.btnHideIcon.Click += new System.EventHandler(this.btnHideIcon_Click);
            // 
            // btnMainIcon
            // 
            this.btnMainIcon.Location = new System.Drawing.Point(41, 54);
            this.btnMainIcon.Name = "btnMainIcon";
            this.btnMainIcon.Size = new System.Drawing.Size(75, 23);
            this.btnMainIcon.TabIndex = 5;
            this.btnMainIcon.Text = "Main icon";
            this.btnMainIcon.UseVisualStyleBackColor = true;
            this.btnMainIcon.Click += new System.EventHandler(this.btnMainIcon_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 80);
            this.Controls.Add(this.btnMainIcon);
            this.Controls.Add(this.btnHideIcon);
            this.Controls.Add(this.btnShowIcon);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbOverlay);
            this.Controls.Add(this.pbTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverlayIcon example";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.PictureBox pbOverlay;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnShowIcon;
        private System.Windows.Forms.NotifyIcon niTest;
        private System.Windows.Forms.Button btnHideIcon;
        private System.Windows.Forms.Button btnMainIcon;
    }
}

