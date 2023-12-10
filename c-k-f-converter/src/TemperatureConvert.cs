using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CKFConverter
{
    public static class TemperatureConvert
    {
        static public double ToDouble(string Number)
        {
            if (String.IsNullOrEmpty(Number)) return 0;
            if (Number == "-") return 0;
            
            Number = Number.Replace(',', '.');
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";
            return Convert.ToDouble(Number, format);
        }

        static public double C2K(double C)
        {
            return C + 273.15;
        }
        static public double C2F(double C)
        {
            return C * 9.0 / 5.0 + 32.0;
        }

        static public double K2C(double K)
        {
            return K - 273.15;
        }
        static public double K2F(double K)
        {
            return (K - 273.15) * 9.0 / 5.0 + 32.0;
        }

        static public double F2C(double F)
        {
            return (F - 32.0) * 5.0 / 9.0;
        }
        static public double F2K(double F)
        {
            return (F - 32.0) * 5.0 / 9.0 + 273.15;
        }
    }
}
