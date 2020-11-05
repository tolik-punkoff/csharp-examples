using System;
using System.Collections.Generic;
using System.Text;

namespace ExitCodeExample
{
    class Program
    {
        //console application return custom exit code
        //use ExitCodeExample.exe <exit_code_number>
        static void print_help()
        {
            Console.WriteLine("console application return custom exit code");
            Console.WriteLine("use ExitCodeExample.exe <exit_code_number -2147483648 .. 2147483647>");
        }
        
        static int Main(string[] args)
        {
            int retcode = 0;

            if (args.Length == 0)
            {
                print_help();
                return 666;
            }

            if (args[0] == "/?")
            {
                print_help();
                return 666;
            }

            bool success = int.TryParse(args[0], out retcode);
            if (!success)
            {
                print_help();
                Console.WriteLine();
                Console.WriteLine("Command line parameter not a inteder number!");
                return 666;
            }

            Console.WriteLine("Return Code: " + retcode.ToString());
            return retcode;
        }
    }
}
