using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddLeaderZeroStringFormat
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
            int maxnum = 1150;
            string FormatPattern = "{0:d" +
                CountDigitsRec(maxnum).ToString() + "}";
            string TempFile = Path.GetTempFileName();
            string Result = "";
            List<string> WriteList = new List<string>();

            for (int i = 0; i <= maxnum; i++)
            {
                Result = String.Format(FormatPattern,i);
                Console.WriteLine(Result);
                WriteList.Add(Result);
            }

            File.WriteAllLines(TempFile, WriteList.ToArray());

            Console.WriteLine("Test file: " + TempFile);
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
