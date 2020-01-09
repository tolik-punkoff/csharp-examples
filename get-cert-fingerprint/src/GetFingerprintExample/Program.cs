using System;
using System.Collections.Generic;
using System.Text;

namespace GetFingerprintExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get X.509 certidicate fingerprint example");
            Console.WriteLine();

            if (args.Length < 2)
            {
                Console.WriteLine("Use:");
                Console.WriteLine("getfingerprintexample.exe <certificate_file> <hash_algorithm>");
                Console.WriteLine("Algorithms: MD5, SHA1, SHA256, SHA384, SHA512");
                Console.WriteLine();
                Console.WriteLine("Press ENTER");
                Console.ReadLine();
                return;
            }

            string FileName = args[0];
            string Algorithm = args[1];

            string result = Fingerpint.GetCertFingerprint(FileName, Algorithm);

            Console.WriteLine("File: " + FileName);
            Console.WriteLine("Algorithm: " + Algorithm);
            Console.WriteLine("Fingerprint: " + result);

            Console.WriteLine();
            Console.WriteLine("Press ENTER");
            Console.ReadLine();
        }
    }
}
