using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class TableItem : UserControl
    {
        public Font SymFont {
            get
            {
                return txtChar.Font;
            }
            set
            {
                txtChar.Font = value;
            }
        }
        public int Code
        {
            get
            {
                if (txtCode.Text != string.Empty)
                {
                    return Convert.ToInt32(txtCode.Text);
                }
                else return 0;
            }
            set
            {
                txtCode.Text = value.ToString();
            }
        }

        public string Chr
        {
            get
            {
                return txtChar.Text;
            }
            set
            {
                txtChar.Text = value;
            }
        }
        
        public TableItem()
        {
            InitializeComponent();
        }
    }
}
