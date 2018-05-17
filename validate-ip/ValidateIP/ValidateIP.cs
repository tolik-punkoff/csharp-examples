using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateIP
{
    public static class ValidateIP
    {
        public static bool isValidIP(string IPAddress)
        {
            char[] ch = new char[1];
            ch[0] = '.';

            string [] IPArr=IPAddress.Split(ch);

            if (IPArr.Length != 4) return false;

            byte b = 0;
            bool res=false;

            for (int i = 0; i < 4; i++)
            {
                res = byte.TryParse(IPArr[i], out b);
                if (!res) return false;
            }

            return true;
        }

        public static bool isValidIP2(string IPAddress)
        {
            char[] ch = new char[1];
            ch[0] = '.';

            string[] IPArr = IPAddress.Split(ch);

            if (IPArr.Length != 4) return false;

            byte b = 0;            

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    b = Convert.ToByte(IPArr[i]);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}
