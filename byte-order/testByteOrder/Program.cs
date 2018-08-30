using System;
using System.Collections.Generic;
using System.Text;

namespace testByteOrder
{
    class Program
    {
        private enum ByteOrder
        {
            BigEndian = 0,
            LittleEndian = 1,
            Unknow = 3
        }
        
        static void Main(string[] args)
        {
         
            //Little Endian - "От младшего к старшему"/обратный/интеловский/VAX
            //Big Endian - "От старшего к младшему"/прямой/сетевой/Motorola byte order

            int Constant = 16909060;
            byte[] LittleEndian = new byte[] {4, 3, 2, 1};
            byte[] BigEndian = new byte[] {1, 2, 3, 4 };

            ushort BigEndianValue = 513;
            byte[] ConvArray = null;
            ushort LittleEndianValue = 0;


            Console.WriteLine("Constant: \t\t\t\t" + Constant);
            Console.WriteLine("Constant as Little Endian array: \t"
                +ShowBytes(LittleEndian));
            Console.WriteLine("Constant as Big Endian array: \t\t" 
                + ShowBytes(BigEndian));
            Console.WriteLine("Constant as BitConverter.GetBytes(): \t"+
                ShowBytes(BitConverter.GetBytes(Constant)));
            Console.WriteLine("________________________________________________________________________");

            Console.WriteLine("Back conversion:");
            Console.WriteLine("Little Endian: \t\t\t\t" +
                BitConverter.ToInt32(LittleEndian,0).ToString());
            Console.WriteLine("Big Endian: \t\t\t\t" +
                BitConverter.ToUInt32(BigEndian, 0).ToString());
            Console.WriteLine("________________________________________________________________________");
            
            Console.WriteLine("Detect:");
            Console.WriteLine("BitConverter.IsLittleEndian: \t\t" + 
                BitConverter.IsLittleEndian.ToString());
            Console.WriteLine("Simple function (DetectBO()): \t\t" +
                DetectBO().ToString());
            Console.WriteLine("________________________________________________________________________");
            
            Console.WriteLine();
            Console.WriteLine("Press enter...");
            Console.ReadLine();                        
        }

        static string ShowBytes(byte[] bytes)
        {
            string s_dec = string.Empty;
            string s_hex = string.Empty;
            
            foreach (byte b in bytes)
            {
                s_dec += Convert.ToString(b)+" ";
                s_hex += Convert.ToString(b,16)+" ";
            }
            return s_dec + "(HEX: " + s_hex.Trim().ToUpperInvariant() + ")";
        }

        static ByteOrder DetectBO()
        {
            
            int Constant = 16909060;
            byte[] LittleEndian = new byte[] { 4, 3, 2, 1 };
            byte[] BigEndian = new byte[] { 1, 2, 3, 4 };

            if (BitConverter.ToInt32(BigEndian, 0) == Constant) 
                return ByteOrder.BigEndian;
            if (BitConverter.ToInt32(LittleEndian, 0) == Constant) 
                return ByteOrder.LittleEndian;
            
            return ByteOrder.Unknow;
        }
        
    }
}
