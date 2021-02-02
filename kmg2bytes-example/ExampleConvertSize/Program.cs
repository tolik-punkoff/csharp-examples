using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleConvertSize
{
    class Program
    {
        public static ulong ToBytes(ulong bytes, string modificator)
        {
            ulong Ret = 0;
            switch (modificator)
            {
                case "":
                    {
                        Ret = bytes;
                    } break;
                case "K":
                case "k":
                    {
                        Ret = bytes * 1024;
                    } break;
                case "M":
                case "m":
                    {
                        Ret = bytes * 1024 * 1024;
                    } break;
                case "G":
                case "g":
                    {
                        Ret = bytes * 1024 * 1024 * 1024;
                    } break;
                default:
                    {
                        throw new ArgumentException("Wrong modificator ["
                            + modificator + "]. Set K(k), M(m), G(g)");
                    }
            }

            return Ret;
        }

        static void PrintHelp()
        {
            Console.WriteLine("Use: example.exe <size>[K|M|G]");
            Console.WriteLine("<size> - size:");
            Console.WriteLine("   default - bytes");
            Console.WriteLine("   K - kilobytes");
            Console.WriteLine("   M - megabytes");
            Console.WriteLine("   G - gigabytes");
            Console.WriteLine();
        }
        
        static int Main(string[] args)
        {

            ulong BytesCount = 0;

            if (args.Length < 1)
            {
                PrintHelp();
                Console.Write("Press Enter...");
                Console.ReadLine();
                return 1;
            }

            if (args[0] == "/?")
            {
                PrintHelp();
                Console.Write("Press Enter...");
                Console.ReadLine();
                return 1;
            }
            string size_s = args[0];
            
            try
            {
                string mdf = size_s.Substring(size_s.Length - 1, 1);
                if ((mdf != "K") && (mdf != "k") && (mdf != "M") && (mdf != "m") &&
                    (mdf != "G") && (mdf != "g"))
                {
                    mdf = "";
                    //in parameter only numbers or param wrong...
                }
                else // remove modificator
                {
                    size_s = size_s.Substring(0, size_s.Length - 1);
                }
                BytesCount = ToBytes(Convert.ToUInt64(size_s), mdf);
            }
            catch (Exception ex)
            {
                PrintHelp();
                Console.WriteLine("Wrong <size> parameter!");
                Console.WriteLine(ex.Message);
                Console.Write("Press Enter...");
                Console.ReadLine();
                return 2;
            }

            Console.WriteLine("Bytes: "+BytesCount);
            Console.Write("Press Enter...");
            Console.ReadLine();

            return 0;
        }
    }
}
