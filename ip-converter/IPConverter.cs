using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace SxGeoReader
{
    public static class IPConverter
    {
        public static bool IsIP(string IP)
        {
            try
            {
                IPAddress addr = IPAddress.Parse(IP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static string ToStandForm(string IP)
        {
            if (!IsIP(IP))
            {
                return string.Empty;
            }
            IPAddress addr = IPAddress.Parse(IP);
            return addr.ToString();
        }
        
        public static int IPToInt32(string IP)
        {
            IPAddress addr = IPAddress.Parse(IP);
            //получаем байты адреса, они всегда в big-endian
            byte[] addrbytes = addr.GetAddressBytes();
            int n = BitConverter.ToInt32(addrbytes,0); //IP в виде Int32 big-endian 
            if (BitConverter.IsLittleEndian) //если в системе little-endian порядок
            {
                n = IPAddress.NetworkToHostOrder(n); //надо перевернуть
            }
            return n;
        }
        
        public static uint IPToUInt32(string IP)
        {
            IPAddress addr = IPAddress.Parse(IP);
            byte[] addrbytes = addr.GetAddressBytes();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(addrbytes);
            }
            return BitConverter.ToUInt32(addrbytes, 0);
        }
        

        public static byte[] GetBytesBE(string IP)
        {
            IPAddress addr = IPAddress.Parse(IP);
            return addr.GetAddressBytes();
        }

        public static byte[] GetBytesLE(string IP)
        {
            IPAddress addr = IPAddress.Parse(IP);
            byte[] addrbytes = addr.GetAddressBytes();
            Array.Reverse(addrbytes);
            return addrbytes;
        }
    }
}
