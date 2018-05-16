namespace TestInternetConnect
{
    partial class frmNetworkSettings
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
            this.grpProxySwitch = new System.Windows.Forms.GroupBox();
            this.btnSystemProxy = new System.Windows.Forms.Button();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbSystemSettings = new System.Windows.Forms.RadioButton();
            this.rbDirectConnect = new System.Windows.Forms.RadioButton();
            this.grpProxy = new System.Windows.Forms.GroupBox();
            this.lblProxyStatus = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.chkSavePassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.lblTimeoutInfo = new System.Windows.Forms.Label();
            this.grpProxySwitch.SuspendLayout();
            this.grpProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProxySwitch
            // 
            this.grpProxySwitch.Controls.Add(this.btnSystemProxy);
            this.grpProxySwitch.Controls.Add(this.rbManual);
            this.grpProxySwitch.Controls.Add(this.rbSystemSettings);
            this.grpProxySwitch.Controls.Add(this.rbDirectConnect);
            this.grpProxySwitch.Location = new System.Drawing.Point(3, 3);
            this.grpProxySwitch.Name = "grpProxySwitch";
            this.grpProxySwitch.Size = new System.Drawing.Size(404, 97);
            this.grpProxySwitch.TabIndex = 0;
            this.grpProxySwitch.TabStop = false;
            this.grpProxySwitch.Text = "Настройки соединения";
            // 
            // btnSystemProxy
            // 
            this.btnSystemProxy.Enabled = false;
            this.btnSystemProxy.Location = new System.Drawing.Point(194, 42);
            this.btnSystemProxy.Name = "btnSystemProxy";
            this.btnSystemProxy.Size = new System.Drawing.Size(204, 21);
            this.btnSystemProxy.TabIndex = 3;
            this.btnSystemProxy.Text = "Открыть \"Свойства обозревателя\"";
            this.btnSystemProxy.UseVisualStyleBackColor = true;
            this.btnSystemProxy.Click += new System.EventHandler(this.btnSystemProxy_Click);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(10, 68);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(162, 17);
            this.rbManual.TabIndex = 2;
            this.rbManual.Text = "Настроить прокси вручную";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbSystemSettings
            // 
            this.rbSystemSettings.AutoSize = true;
            this.rbSystemSettings.Location = new System.Drawing.Point(10, 44);
            this.rbSystemSettings.Name = "rbSystemSettings";
            this.rbSystemSettings.Size = new System.Drawing.Size(178, 17);
            this.rbSystemSettings.TabIndex = 1;
            this.rbSystemSettings.TabStop = true;
            this.rbSystemSettings.Text = "Системные настройки прокси";
            this.rbSystemSettings.UseVisualStyleBackColor = true;
            this.rbSystemSettings.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbDirectConnect
            // 
            this.rbDirectConnect.AutoSize = true;
            this.rbDirectConnect.Checked = true;
            this.rbDirectConnect.Location = new System.Drawing.Point(10, 20);
            this.rbDirectConnect.Name = "rbDirectConnect";
            this.rbDirectConnect.Size = new System.Drawing.Size(145, 17);
            this.rbDirectConnect.TabIndex = 0;
            this.rbDirectConnect.TabStop = true;
            this.rbDirectConnect.Text = "Соединяться напрямую";
            this.rbDirectConnect.UseVisualStyleBackColor = true;
            this.rbDirectConnect.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // grpProxy
            // 
            this.grpProxy.Controls.Add(this.lblProxyStatus);
            this.grpProxy.Controls.Add(this.chkShowPassword);
            this.grpProxy.Controls.Add(this.chkSavePassword);
            this.grpProxy.Controls.Add(this.txtPassword);
            this.grpProxy.Controls.Add(this.lblPassword);
            this.grpProxy.Controls.Add(this.txtUser);
            this.grpProxy.Controls.Add(this.lblUser);
            this.grpProxy.Controls.Add(this.txtPort);
            this.grpProxy.Controls.Add(this.lblPort);
            this.grpProxy.Controls.Add(this.txtAddress);
            this.grpProxy.Controls.Add(this.lblAddress);
            this.grpProxy.Enabled = false;
            this.grpProxy.Location = new System.Drawing.Point(3, 107);
            this.grpProxy.Name = "grpProxy";
            this.grpProxy.Size = new System.Drawing.Size(404, 143);
            this.grpProxy.TabIndex = 1;
            this.grpProxy.TabStop = false;
            this.grpProxy.Text = "Настройки прокси";
            // 
            // lblProxyStatus
            // 
            this.lblProxyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProxyStatus.ForeColor = System.Drawing.Color.Red;
            this.lblProxyStatus.Location = new System.Drawing.Point(10, 117);
            this.lblProxyStatus.Name = "lblProxyStatus";
            this.lblProxyStatus.Size = new System.Drawing.Size(384, 23);
            this.lblProxyStatus.TabIndex = 10;
            this.lblProxyStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(220, 97);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(124, 17);
            this.chkShowPassword.TabIndex = 9;
            this.chkShowPassword.Text = "Показать символы";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // chkSavePassword
            // 
            this.chkSavePassword.AutoSize = true;
            this.chkSavePassword.Location = new System.Drawing.Point(96, 97);
            this.chkSavePassword.Name = "chkSavePassword";
            this.chkSavePassword.Size = new System.Drawing.Size(118, 17);
            this.chkSavePassword.TabIndex = 8;
            this.chkSavePassword.Text = "Сохранять пароль";
            this.chkSavePassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(298, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(96, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(298, 20);
            this.txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Пользователь:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(344, 20);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(303, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Порт:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(56, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(241, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 23);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Адрес:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 279);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(125, 253);
            this.txtTimeout.MaxLength = 5;
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(100, 20);
            this.txtTimeout.TabIndex = 4;
            this.txtTimeout.Text = "0";
            this.txtTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeout_KeyPress);
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(3, 256);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(116, 13);
            this.lblTimeout.TabIndex = 5;
            this.lblTimeout.Text = "Таймаут соединения:";
            // 
            // lblTimeoutInfo
            // 
            this.lblTimeoutInfo.AutoSize = true;
            this.lblTimeoutInfo.Location = new System.Drawing.Point(232, 257);
            this.lblTimeoutInfo.Name = "lblTimeoutInfo";
            this.lblTimeoutInfo.Size = new System.Drawing.Size(166, 13);
            this.lblTimeoutInfo.TabIndex = 6;
            this.lblTimeoutInfo.Text = " миллисекунд 0 - по умолчанию";
            // 
            // frmNetworkSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 304);
            this.Controls.Add(this.lblTimeoutInfo);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpProxy);
            this.Controls.Add(this.grpProxySwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNetworkSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки сети";
            this.Load += new System.EventHandler(this.frmNetworkSettings_Load);
            this.Shown += new System.EventHandler(this.frmNetworkSettings_Shown);
            this.grpProxySwitch.ResumeLayout(false);
            this.grpProxySwitch.PerformLayout();
            this.grpProxy.ResumeLayout(false);
            this.grpProxy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProxySwitch;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbSystemSettings;
        private System.Windows.Forms.RadioButton rbDirectConnect;
        private System.Windows.Forms.GroupBox grpProxy;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.CheckBox chkSavePassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSystemProxy;
        private System.Windows.Forms.Label lblProxyStatus;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblTimeoutInfo;
    }
}