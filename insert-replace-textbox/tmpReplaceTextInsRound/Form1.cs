using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpReplaceTextInsRound
{
    public partial class frmTest : Form
    {
        bool InsertMode = false;

        public frmTest()
        {
            InitializeComponent();
        }



        private void txtTest_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                InsertMode = !InsertMode;
                lblInsertMode.Text = InsertMode.ToString();
            }

        }

        private void txtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (InsertMode && !Char.IsControl(e.KeyChar))
            {
                //замена по кругу
                if (tb.SelectionStart == tb.MaxLength) tb.SelectionStart = 0;

                //выделяем 1 символ перед курсором
                //область выделения автоматически заменится 
                //символом, введенным  с клавиатуры
                tb.SelectionLength = 1;

                //если выделен символ перевода строки, значит это конец строки 
                //в multiline TextBox,  
                if (tb.SelectedText == "\r" || tb.SelectedText == "\n")
                    tb.SelectionLength = 0; //не надо ничего заменять, убираем выделение
            }
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            lblInsertMode.Text = InsertMode.ToString();
        }
    }
}
