using System;
using System.Collections.Generic;
using System.Text;

namespace OSVersionExample
{
    class Program
    {
        static string DataOutput(string stData)
        {
            if (string.IsNullOrEmpty(stData))
            {
                if (string.IsNullOrEmpty(VersionDetect.ErrorMessage))
                {
                    return "None or unknow.";
                }
                else
                {
                    return "ERROR! " + VersionDetect.ErrorMessage;
                }
            }

            return stData;
        }
        
        static void Main(string[] args)
        {            
            Console.WriteLine();
            Console.WriteLine("============== Get OS Version information ==============");
            Console.WriteLine();
            
            Console.WriteLine("--------------------- From WMI -------------------------");
            Console.WriteLine("Name: "+ DataOutput(VersionDetect.GetOSNameWMI()));
            Console.WriteLine("Service Pack: " + DataOutput(VersionDetect.GetOSSPWMI()));
            Console.WriteLine("Version: " + DataOutput(VersionDetect.GetOSVersionWMI()));
            Console.WriteLine("Architecture: " + DataOutput(VersionDetect.GetOSArchWMI()));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------- From Registry --------------------");
            Console.WriteLine("Name: " + DataOutput(VersionDetect.GetOSNameReg()));
            Console.WriteLine("Service Pack: " + DataOutput(VersionDetect.GetOSSPReg()));
            Console.WriteLine("Version: " + DataOutput(VersionDetect.GetOSVersionReg()));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            if (VersionDetect.Is64BitOperatingSystem)
            {
                Console.WriteLine("OS Architecture: 64-bit");
            }
            else
            {
                Console.WriteLine("OS Architecture: 32-bit");
            }
            Console.WriteLine();

            Console.Write("Press Enter ");
            Console.ReadLine();            
        }
    }
}
