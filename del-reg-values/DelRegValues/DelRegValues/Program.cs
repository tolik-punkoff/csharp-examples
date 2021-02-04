using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace DelRegValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string subkey = "Software\\TestKey";
            RegistryKey key = null;

            try
            {

                key = Registry.CurrentUser.OpenSubKey(subkey, true);

                foreach (string valname in key.GetValueNames())
                {
                    Console.WriteLine("Delete value: " + valname);
                    key.DeleteValue(valname);
                }

                key.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.Write("Press enter...");
            Console.ReadLine();
        }
    }
}
