using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleColorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Art = new string[16];
            Art[0] = "        Make C0DE, Not War. C# Like You!";
            Art[1] = "    ########                            ";
            Art[2] = "  ##############                        ";
            Art[3] = "########  ######          ##      ####";
            Art[4] = "########  ######          ##      ####  ";
            Art[5] = "########  ######        ####      ####  ";
            Art[6] = "########  ######    ####################";
            Art[7] = "        ########                ##      ####    ";
            Art[8] = "########                ##        ##    ";
            Art[9] = "        ########                ##      ####    ";
            Art[10] = "        ########  ######    ####################";
            Art[11] = "        ########  ######      ####    ######    ";
            Art[12] = "        ########  ######      ##        ##      ";
            Art[13] = "  ##############      ##      ####      ";
            Art[14] = "            ############      ####    ####";
            Art[15] = "        Console Color Demo";
            
            int i = 0;
            foreach (string name in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = (ConsoleColor)i;
                if (i == 0) 
                    Console.BackgroundColor = ConsoleColor.Gray;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("{0,2} \t {1}\t\t{2}", 
                    i, name, Art[i]);
                i++;
            }

            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
            Console.Clear();

            i = 0;
            foreach (string name in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = (ConsoleColor)i;
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Gray;
                else
                    Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0,2} \t {1}\t\t{2}",
                    i, name, Art[i]);
                i++;
            }

            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
