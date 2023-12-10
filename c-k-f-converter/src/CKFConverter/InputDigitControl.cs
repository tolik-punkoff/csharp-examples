using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Wildsoft.Controls
{
    public class InputDigitControl:TextBox
    {
        const int WM_KEYDOWN = 0x100; //Windows Message нажатие клавиши
        const int WM_PASTE = 0x0302; //Сообщение "Вставка" (вставить текст через контекстное меню)
        const int WM_CHAR = 0x0102; //Сообщение - нажатие алфавитно-цифровой клавиши

        [Description("Enable or disable negative number input"), 
        Category("Behavior"), DefaultValue(false)]
        public bool Negative { get; set; } //включает/отключает ввод отрицательных чисел
        [Description("Enable or disable negative number input"),
        Category("Behavior"), DefaultValue(false)]
        public bool Fractional { get; set; } //включает/отключает ввод дробных чисел

        private char separator = '.';
        [Description("Decimal separator, may be '.' or ','"),
        Category("Format"), DefaultValue('.')] //разделитель дробной и целой части числа
        public char Separator 
        {
            get { return separator; }
            set
            {
                if ((value != '.') && (value != ','))
                {
                    throw new ArgumentOutOfRangeException("Separator",
                        "Value must be '.' or ','");
                }
                else
                {
                    separator = value;
                }
            }
        } 

        public override bool PreProcessMessage(ref Message msg)
        {
            if (msg.Msg == WM_CHAR)
            {
                //в была нажата комбинация клавиш
                if ((ModifierKeys != Keys.None)&&
                    (ModifierKeys != Keys.Shift)) return false;
                                
                //получаем char из кода символа в WParam
                char chr = (char)msg.WParam.ToInt32();

                if (chr == '\b') return false; //backspace

                //это цифры (ура, товарищи)
                if (chr >= '0' && chr <= '9')
                {
                    return false;
                }
                else
                {
                    //получаем текущую позицию курсора для вставки точки/минуса
                    int pos = this.SelectionStart;

                    //нажали минус, ввод отрицательных разрешен свойством Negative
                    if (chr == '-' && Negative)
                    {                        
                        if (this.Text.StartsWith("-")) //минус уже есть
                        {
                            this.Text = this.Text.Substring(1);//убираем
                            //ставим курсор на прежнюю позицию. 
                            //Т.е. на -1 от текущей, т.к. удалили 1 символ
                            this.SelectionStart = pos - 1;
                        }
                        else //минуса нет
                        {
                            this.Text = "-" + this.Text; //добавили
                            //переставили курсор
                            this.SelectionStart = pos + 1;
                        }
                        
                    } //конец ввод отрицательных

                    //ввод разделителя дробной части
                    //поле реагирует и на . и на ,
                    if ((chr == '.' || chr == ',') && Fractional)
                    {
                        //проверяем, чтоб в строке не было двух разделителей
                        if (this.Text.Contains(separator.ToString()))
                        {
                            return true;
                        }

                        //если поле пустое, добавляем 0 перед разделителем
                        if (this.Text == string.Empty)
                        {
                            this.Text = "0" + separator.ToString();
                            //ставим курсор в конец текста
                            this.SelectionStart = this.Text.Length;
                        }
                        else //меняем WParam на код разделителя
                        {
                            msg.WParam = (IntPtr)separator;
                            return false;
                        }
                    }
                    return true;
                }
            }

            return base.PreProcessMessage(ref msg);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE) //перехватываем сообщение "вставка"
            {
                //получаем строку из буфера обмена
                IDataObject obj = Clipboard.GetDataObject();
                string input = (string)obj.GetData(typeof(string));
                int sepctr = 0; //счетчик разделителей
                                                
                for (int i = 0; i < input.Length;i++ )
                {
                    if (i == 0) //проверяем первый символ на минус
                    {
                        //минус и разрешен ввод отрицательных чисел разрешен
                        if (input[i] == '-' && Negative) continue;
                    }

                    //в строке присутствует разделитель, 
                    //ввод дробных чисел разрешен
                    if ((input[i] == '.' || input[i] == ',') && Fractional)
                    {
                        sepctr++; //подсчет разделителей
                        
                        //больше 2 разделителей
                        if (sepctr > 1)
                        {
                            m.Result = (IntPtr)0; //отменяем вставку
                            return;
                        }
                        else continue;
                    }

                    //если символ не цифра
                    if (!char.IsDigit(input[i]))
                    {
                        m.Result = (IntPtr)0; //отменяем вставку
                        return;
                    }
                }
                //не-цифр не найдено

                //вставка чисел целиком
                this.Text = string.Empty;
                
                if (Fractional)
                {
                    //заменяем возможные разделители на установленный в контроле
                    input = input.Replace('.', separator);
                    input = input.Replace(',', separator);
                    
                    //меняем содержимое буфера
                    Clipboard.SetText(input);
                }
            }

            base.WndProc(ref m);
        }
        
    }
}
