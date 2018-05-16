using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestInternetConnect
{
    public partial class frmTestConfig : Form
    {
        public frmTestConfig()
        {
            InitializeComponent();
        }

        TestSettings settings = null;

        private void frmTestConfig_Load(object sender, EventArgs e)
        {
            settings = new TestSettings(cf.TestConfigFile);

            if (!settings.LoadConfig())
            {
                MessageBox.Show(settings.ConfigError, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            txtURL.Text = settings.URL;
            txtPause.Text = settings.PauseTime.ToString();
        }

        private void txtPause_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No URL!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int pause = 0;
            if (Int32.TryParse(txtPause.Text, out pause))
            {
                if (pause > 50)
                {
                    MessageBox.Show("Пауза между соединениями должна быть не больше 50 с.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пауза задана неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            settings.URL = txtURL.Text;
            settings.PauseTime = pause;

            if (!settings.SaveConfig())
            {
                MessageBox.Show("Не удалось сохранить настройки! \n"+settings.ConfigError, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
