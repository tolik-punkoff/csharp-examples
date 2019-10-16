using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PopupForm
{
    public partial class frmPopup : Form
    {
        public frmPopup()
        {
            InitializeComponent();
            //Настройка формы
            this.TopMost = false;
            this.ShowInTaskbar = false;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public string MessageText = "";
        private int StartPosX; private int StartPosY;

        protected override void OnLoad(EventArgs e)
        {
            //Прячем форму за экран
            StartPosX = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            StartPosY = Screen.PrimaryScreen.WorkingArea.Height;
            SetDesktopLocation(StartPosX, StartPosY);
            base.OnLoad(e);
            //запуск анимации всплытия
            tmrAni.Interval = 50;
            tmrAni.Start();

        }

        private void frmPopup_Load(object sender, EventArgs e)
        {
            //настраиваем TextBox с сообщением
            txtMessage.Height = this.Height - txtMessage.Location.Y - 3;
            txtMessage.Width = this.Width - txtMessage.Location.X - 3;
            txtMessage.BorderStyle = BorderStyle.None;
            txtMessage.BackColor = this.BackColor;
            txtMessage.Text = MessageText;
            txtMessage.ReadOnly = true;
            txtMessage.SelectionStart = 0;

            //и кнопку закрытия
            int CloseX = this.Width - pbClose.Width - 3;
            int CloseY = 3;
            pbClose.Location = new Point(CloseX, CloseY);
        }
        
        private void frmPopup_Shown(object sender, EventArgs e)
        {
            HideCaret(txtMessage.Handle);
        }

        private void tmrAni_Tick(object sender, EventArgs e)
        {
            //поднимаем форму на 5 пикселей
            StartPosY -= 5;

            //Если окно видно полностью - останавливаем таймер
            if (StartPosY < Screen.PrimaryScreen.WorkingArea.Height - Height)
            {
                tmrAni.Stop();
                this.TopMost = true;
            }
            else
            {
                SetDesktopLocation(StartPosX, StartPosY);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
