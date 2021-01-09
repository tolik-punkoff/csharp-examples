using System;
using System.Collections.Generic;
using System.Text;

namespace testFill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start tests...");

            DateTime StartDT = DateTime.Now;

            int items = 536870912;
            byte[] tArr = new byte[items];

            for (int i = 0; i < items; i++)
            {
                tArr[i] = 0xFF;
            }

            DateTime EndDT = DateTime.Now;
            Console.WriteLine("For: " + (EndDT - StartDT).ToString());
            
            //--------------

            StartDT = DateTime.Now;

            tArr[0] = 0xFF;
            for (int i = 1; i <= items / 2; i *= 2)
            {
                Array.Copy(tArr, 0, tArr, i, i);
                Array.Copy(tArr, 0, tArr, i, items - i);
            }

            EndDT = DateTime.Now;
            Console.WriteLine("For+Array.Copy(): "+(EndDT - StartDT).ToString());
            
            //----------------
            
            StartDT = DateTime.Now;

            byte[] Ret = FillArray.FillBytes(items, 0xFF);

            EndDT = DateTime.Now;
            Console.WriteLine("MemSet (msvcrt.dll): " + (EndDT - StartDT).ToString());
            
            //----------------

            StartDT = DateTime.Now;

            FillArray.FillRandomBytes(items);

            EndDT = DateTime.Now;
            Console.WriteLine("Random bytes (RNGCryptoServiceProvider): " + (EndDT - StartDT).ToString());
            Console.WriteLine("Press Enter...");
            Console.ReadLine();            
        }
    }
}
