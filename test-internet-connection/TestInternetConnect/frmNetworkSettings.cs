using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestInternetConnect
{
    public partial class frmNetworkSettings : Form
    {        
        public bool Chanded = false;
        NetConnectionType proxy = NetConnectionType.NoProxy;

        public frmNetworkSettings()
        {
            InitializeComponent();
        }
        
        NetSettings settings = new NetSettings(cf.ConfigFile);

        private void frmNetworkSettings_Load(object sender, EventArgs e)
        {
            NetConfigStatus cstat = settings.LoadConfig();
            if (cstat==NetConfigStatus.Error)
            {
                MessageBox.Show("Файл конфигурации поврежден!\n"+
                    settings.ConfigError,
                    "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            switch (settings.ConnectionType)
            {
                case NetConnectionType.NoProxy: rbDirectConnect.Checked = true; break;
                case NetConnectionType.SystemProxy: rbSystemSettings.Checked = true; break;
                case NetConnectionType.ManualProxy: rbManual.Checked = true; break;
            }
            txtAddress.Text = settings.ProxyAddress;
            txtPort.Text = settings.ProxyPort.ToString();
            txtUser.Text = settings.ProxyUser;
            txtTimeout.Text = settings.ConnectionTimeout.ToString();
            if (cstat != NetConfigStatus.ProxyPassNotDecrypted)
            {
                txtPassword.Text = settings.ProxyPassword;
            }
            else
            {
                txtPassword.Text = "";
                lblProxyStatus.Text = "Сохраненный пароль не был расшифрован.";
            }
            chkShowPassword.Checked = settings.ShowChars;
            chkSavePassword.Checked = settings.SavePassword;            
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только цифр
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }            
        }
        private void txtTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только цифр
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }            
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbDirectConnect":
                        {
                            proxy = NetConnectionType.NoProxy;

                        }; break;
                    case "rbSystemSettings":
                        {
                            proxy = NetConnectionType.SystemProxy;
                        }; break;
                    case "rbManual":
                        {
                            proxy = NetConnectionType.ManualProxy;
                        }; break;
                }
            }

            btnSystemProxy.Enabled = rbSystemSettings.Checked;
            grpProxy.Enabled = rbManual.Checked;            
        }

        private void frmNetworkSettings_Shown(object sender, EventArgs e)
        {
            //rbAll_CheckedChanged(null, null);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (Int32.TryParse(txtPort.Text, out port))
            {
                if (port > 65535)
                {
                    MessageBox.Show("Порт должен быть не больше 65535", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Номер порта задан неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int timeout = 0;
            if (Int32.TryParse(txtTimeout.Text, out timeout))
            {
                if (timeout > 55999)
                {
                    MessageBox.Show("Таймаут соединения должен быть не больше 55999", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Таймаут задан неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            settings.ConnectionType = proxy;
            settings.ProxyAddress = txtAddress.Text;
            settings.ProxyPort = port;
            settings.ProxyUser = txtUser.Text;
            settings.ProxyPassword = txtPassword.Text;
            settings.ShowChars = chkShowPassword.Checked;
            settings.SavePassword = chkSavePassword.Checked;
            settings.ConnectionTimeout = timeout;

            if (!settings.SaveConfig())
            {
                MessageBox.Show("Не удалось сохранить настройки! \n" + settings.ConfigError, "Ошибка",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Chanded = true;
            this.Close();
        }                

        private void btnSystemProxy_Click(object sender, EventArgs e)
        {
            NetSettings.ShowSystemProxyWindow();
        }

        
    }
}
