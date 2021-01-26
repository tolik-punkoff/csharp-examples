using System;
using System.Collections.Generic;
using System.Text;

namespace AddLeaderZeroWriteLine
{
    class Program
    {
        static int CountDigitsRec(int n)
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

        static void Main(string[] args)
        {
            int maxnum = 150;
            string FormatPattern = "{0:d" +
                CountDigitsRec(maxnum).ToString() + "}";

            for (int i = 0; i <= maxnum; i++)
            {
                Console.WriteLine(FormatPattern, i);
            }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
