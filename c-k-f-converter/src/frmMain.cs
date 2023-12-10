using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wildsoft.Controls;

namespace CKFConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool enC = false; bool enK = false; bool enF = false;

        private void idc_Changed(object sender, EventArgs e)
        {
            InputDigitControl idc = (InputDigitControl)sender;
            string fldID = idc.Name.Substring(3, 1);

            double V = TemperatureConvert.ToDouble(idc.Text);
            
            switch (fldID)
            {
                case "C":
                    {
                        if (!enC) return;
                        if (V < -273.15)
                        {
                            lblError.Text = "Такой температуры не бывает!";
                            return;
                        }

                        idcK.Text = TemperatureConvert.C2K(V).ToString();
                        idcF.Text = TemperatureConvert.C2F(V).ToString();
                        lblError.Text = "";
                    }; break;
                case "K":
                    {
                        if (!enK) return;
                        idcC.Text = TemperatureConvert.K2C(V).ToString();
                        idcF.Text = TemperatureConvert.K2F(V).ToString();
                    }; break;
                case "F":
                    {
                        if (!enF) return;
                        if (V < -459.67)
                        {
                            lblError.Text = "Такой температуры не бывает!";
                            return;
                        }

                        idcC.Text = TemperatureConvert.F2C(V).ToString();
                        idcK.Text = TemperatureConvert.F2K(V).ToString();
                        lblError.Text = "";
                    }; break;
            }
        }

        private void idc_Enter(object sender, EventArgs e)
        {
            InputDigitControl idc = (InputDigitControl)sender;
            string fldID = idc.Name.Substring(3, 1);

            switch (fldID)
            {
                case "C":
                    {
                        enC = true;
                        enK = false;
                        enF = false;
                    }; break;
                case "K":
                    {
                        enC = false;
                        enK = true;
                        enF = false;
                    }; break;
                case "F":
                    {
                        enC = false;
                        enK = false;
                        enF = true;
                    }; break;
            }
        }
    }
}
