using System;
using System.Collections.Generic;
using System.Text;

namespace GenOneSymString
{
    class Program
    {
        static void Main(string[] args)
        {
            int strlen = 100000;
            string symbol = "a";
            string Result = "";

            Console.WriteLine("Start tests...");
            Console.WriteLine("Test For + standart string concatenation:");
            DateTime StartDT = DateTime.Now;

            for (int i = 0; i < strlen; i++)
            {
                Result = Result + symbol;
            }

            DateTime EndDT = DateTime.Now;
            Console.WriteLine("For: " + (EndDT - StartDT).ToString());

            //----------------------------------------------------------

            Console.WriteLine("Test For + StringBuilder.Append:");
            StartDT = DateTime.Now;


            StringBuilder sb = new StringBuilder(strlen);
            for (int i = 0; i < strlen; i++)
            {
                sb.Append(symbol);
            }

            Result = sb.ToString();
            EndDT = DateTime.Now;
            Console.WriteLine("StringBuilder: " + (EndDT - StartDT).ToString());

            Console.WriteLine("Press Enter...");
            Console.ReadLine();            
        }
    }
}
