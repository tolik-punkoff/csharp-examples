using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FindFilesByMask
{
    class Program
    {
        static void PrintHelp()
        {
            string exename = Path.GetFileName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location);

            Console.WriteLine("Test application, find files by mask in directory");
            Console.WriteLine("Use: " + exename + " <mask> [/S]");
            Console.WriteLine("<mask> - file mask (e.g. *.jpg)");
            Console.WriteLine("[/S] - with subdirs");

            Console.Write("Press Enter...");
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                PrintHelp();
                return;
            }

            if (args[0]=="/?")
            {
                PrintHelp();
                return;
            }

            SearchOption SO = SearchOption.TopDirectoryOnly;
            if (args.Length >= 2)
            {
                if (args[1].ToUpperInvariant() == "/S")
                {
                    SO = SearchOption.AllDirectories;
                }
            }


            string[] FoundFiles = FindFiles.Find(Environment.CurrentDirectory, args[0], 
                SO);

            foreach (string file in FoundFiles)
            {
                Console.WriteLine("Find: " + file);
            }

            Console.WriteLine("Total: " + FoundFiles.Length.ToString(), 
                "Mask: " + args[0]);
            
            Console.Write("Press Enter...");
            Console.ReadLine();
        }
    }
}
