using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FilesGenerator
{
    class Program
    {
        static void Penter()
        {            
            Console.Write("Press Enter...");
            Console.ReadLine();
        }
        static void PrintHelp()
        {
            string exename = Path.GetFileName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location);

            Console.WriteLine("File Generator example");
            Console.WriteLine("Use: " + exename + " <count> <size>[K|M|G] " +
                "<extension|/R> [byte_pattern|/R]");
            Console.WriteLine();
            Console.WriteLine("<count> - files count (Max: " + ulong.MaxValue.ToString() + ")");
            Console.WriteLine("<size> - size:");
            Console.WriteLine("   default - bytes");
            Console.WriteLine("   K - kilobytes");
            Console.WriteLine("   M - megabytes");
            Console.WriteLine("   G - gigabytes");
            Console.WriteLine("<extension> - file extension OR /R - random file name");
            Console.WriteLine("[byte_pattern] - byte pattern (HEX): 0x00..0xFF, default 0x00 OR /R random bytes");
            Console.WriteLine();
        }

        static int Main(string[] args)
        {
            ulong FilesCount = 0;
            ulong BytesCount = 0;
            bool RandomName = false;
            string Extension = "";
            bool RandomBytes = false;
            byte BytePattern = 0x00;

            //Print Help and check parameters count
            if (args.Length < 1)
            {
                PrintHelp();
                Penter();
                return 1;
            }
            else
            {
                if (args[0] == "/?")
                {
                    PrintHelp();
                    Penter();
                    return 1;
                }
            }
            if (args.Length < 3)
            {
                PrintHelp();
                Penter();
                return 1;
            }
            
            // Check and set parameters...
            // files count
            try
            {
                FilesCount = Convert.ToUInt64(args[0]);
            }
            catch(Exception ex)
            {
                PrintHelp();
                Console.WriteLine("Wrong <count> parameter!");
                Console.WriteLine(ex.Message);
                Penter();
                return 2;
            }

            //file size
            string size_s = args[1];
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
                BytesCount = CF.ToBytes(Convert.ToUInt64(size_s), mdf);
            }
            catch (Exception ex)
            {
                PrintHelp();
                Console.WriteLine("Wrong <size> parameter!");
                Console.WriteLine(ex.Message);
                Penter();
                return 2;
            }
            
            //extension
            if ((args[2] == "/R") || (args[2] == "/r"))
            {
                RandomName = true;
            }
            else
            {
                Extension = args[2];
            }

            //byte pattern
            if (args.Length >= 4)
            {
                if ((args[3] == "/R") || (args[3] == "/r"))
                {
                    RandomBytes = true;
                }
                else
                {
                    try
                    {
                        BytePattern = Convert.ToByte(args[3],16);
                    }
                    catch (Exception ex)
                    {
                        PrintHelp();
                        Console.WriteLine("Wrong [byte_pattern] parameter!");
                        Console.WriteLine(ex.Message);
                        Penter();
                        return 2;
                    }
                }
            }

            CF.GenFiles(FilesCount, BytesCount, RandomName,
                Extension, RandomBytes, BytePattern);
            Console.WriteLine();
            Penter();
            return 0;
        }
    }
}
