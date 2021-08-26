using System;
using System.Collections.Generic;
using System.Text;

namespace write2stderr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write to STDOUT.");
            Console.Error.WriteLine("Write to STDERR.");
        }
    }
}
