using System;
using System.Collections.Generic;
using System.Text;

namespace AddLeaderZeros
{
    public static class AddLZ
    {
        public static int CountDigitsRec(int n)
        {
            n = (int)Math.Abs(n);
            if (n <= 9)
            {
                return 1;
            }
            else
            {
                return CountDigitsRec(n / 10) + 1;
            }
        }

        public static string AddLeaderZeroString(int maxnum, int curnum)
        {
            string scurnum = ((int)Math.Abs(curnum)).ToString();
            int LenLZ = maxnum - scurnum.Length;

            StringBuilder sb = new StringBuilder(maxnum);
            for (int i = 0; i < LenLZ; i++)
            {
                sb.Append('0');
            }
            sb.Append(scurnum);

            return sb.ToString();
        }
    }
}
