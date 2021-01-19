using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddLeaderZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxnumber = 1998;
            int maxdigits = AddLZ.CountDigitsRec(maxnumber);
            string TempFile = Path.GetTempFileName();
            string Result = "";
            List<string> WriteList = new List<string>();

            for (int i = 0; i <= maxnumber ; i++)
            {
                Result = AddLZ.AddLeaderZeroString(maxdigits, i);
                Console.WriteLine(Result);
                WriteList.Add(Result);
            }

            File.WriteAllLines(TempFile, WriteList.ToArray());

            Console.WriteLine("Test file: " + TempFile);
            Console.Write("Press enter...");
            Console.ReadLine();
        }
    }
}
