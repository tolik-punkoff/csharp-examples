using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace OSVersionExample
{
    public static class VersionDetect
    {
        public static string ErrorMessage { get; private set; }
                
        public static bool Is64BitOperatingSystem
        {
            get
            {
                // Clearly if this is a 64-bit process we must be on a 64-bit OS.
                if (IntPtr.Size == 8)
                    return true;
                // Ok, so we are a 32-bit process, but is the OS 64-bit?
                // If we are running under Wow64 than the OS is 64-bit.
                bool isWow64;
                return ModuleContainsFunction("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out isWow64) && isWow64;
            }
        }


        #region winapi
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        extern static bool IsWow64Process(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] out bool isWow64);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        extern static IntPtr GetCurrentProcess();
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        extern static IntPtr GetModuleHandle(string moduleName);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        extern static IntPtr GetProcAddress(IntPtr hModule, string methodName);
        #endregion

        #region call_wmi_and_registry
        private static string CallWMI(string WMIProperty)
        {
            string ret = null;

            ManagementObjectSearcher mos = new 
                ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_OperatingSystem");

            try
            {
                foreach (ManagementObject MObj in mos.Get())
                {
                    ret = MObj.GetPropertyValue(WMIProperty).ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            
            return ret;
        }

        private static string CallRegistry(string RegValueName)
        {
            string ret = null;

            try
            {
                RegistryKey key = Registry.LocalMachine.
                OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\");
                ret = key.GetValue(RegValueName).ToString();
                key.Close();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                ret = null;
            }

            return ret;
        }
        #endregion

        #region get_wmi_data
        public static string GetOSVersionWMI()
        {
            ErrorMessage = string.Empty;
            return CallWMI("Version");
        }

        public static string GetOSNameWMI()
        {
            ErrorMessage = string.Empty;
            return CallWMI("Caption");
        }

        public static string GetOSSPWMI()
        {
            ErrorMessage = string.Empty;
            return CallWMI("CSDVersion");            
        }

        public static string GetOSArchWMI()
        {
            ErrorMessage = string.Empty;
            return CallWMI("OSArchitecture");
        }
        #endregion

        #region get_reg_data
        public static string GetOSVersionReg()
        {
            ErrorMessage = string.Empty;
            string Version = CallRegistry("CurrentVersion");
            string Build = CallRegistry("CurrentBuildNumber");

            if ((Version == null) || (Build == null))
            {
                return null;
            }

            return Version + "." + Build;
        }

        public static string GetOSNameReg()
        {
            ErrorMessage = string.Empty;
            return CallRegistry("ProductName");
        }

        public static string GetOSSPReg()
        {
            ErrorMessage = string.Empty;
            return CallRegistry("CSDVersion");
        }
        #endregion

        
        static bool ModuleContainsFunction(string moduleName, string methodName)
        {
            IntPtr hModule = GetModuleHandle(moduleName);
            if (hModule != IntPtr.Zero)
                return GetProcAddress(hModule, methodName) != IntPtr.Zero;
            return false;
        }        

    }
}
