using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpReplaceTextIns
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
            //Вытаскиваю объект, который вызвал событие, 
            //чтоб можно было подключить несколько TextBox'ов
            TextBox tb = (TextBox)sender;
            
            //если включен соотв. режим, курсор не в конце текста
            //и не нажата какая-либо управляющая клавиша
            //заменим символ перед курсором
            if (InsertMode && tb.SelectionStart < tb.TextLength 
                && !Char.IsControl(e.KeyChar))
            {                                
                //выделяем 1 символ перед курсором
                //область выделения автоматически заменится 
                //символом, введенным  с клавиатуры
                tb.SelectionLength  = 1;

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
