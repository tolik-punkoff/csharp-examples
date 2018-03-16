using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Code = 0x14476; //анатолийский иероглиф
        string myString = "In the game of mahjong \U0001F01C denotes the Four of circles";
        Font AnFont = new Font("Anatolian", 24, FontStyle.Regular, GraphicsUnit.Pixel, 1);
        private void Form1_Load(object sender, EventArgs e)
        {
            string strSP = char.ConvertFromUtf32(Code);
            
            lblTest.Font = AnFont;
            txtTest.Font = AnFont;                        
            lblFont.Text = AnFont.FontFamily.Name;
            rtbTest.Font = AnFont;

            lblTest.Text = strSP;
            txtTest.Text = strSP;
            rtbTest.Text = strSP;

            

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult Ans = dlgFont.ShowDialog();
            if (Ans == DialogResult.Cancel) return;
            

            lblTest.Font = dlgFont.Font;
            txtTest.Font = dlgFont.Font;
            rtbTest.Font = dlgFont.Font;
            lblFont.Text = dlgFont.Font.Name;
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            string strSP = char.ConvertFromUtf32(Code);
            MessageBox.Show(strSP);
        }
    }
}
