using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace testFill
{
    public static class FillArray
    {
        [DllImport("msvcrt.dll",
        EntryPoint = "memset",
        CallingConvention = CallingConvention.Cdecl,
        SetLastError = false)]

        private static extern IntPtr MemSet(IntPtr dest, int value, int count);

        public static byte[] FillBytes(int Length, byte Value)
        {
            byte[] Arr = new byte[Length];
            GCHandle GCH = GCHandle.Alloc(Arr, GCHandleType.Pinned);
            MemSet(GCH.AddrOfPinnedObject(), (int)Value, Length);
            return Arr;
        }

        public static byte[] FillRandomBytes(int Length)
        {
            byte[] Arr = new byte[Length];
            RNGCryptoServiceProvider RngCsp = new RNGCryptoServiceProvider();
            RngCsp.GetBytes(Arr);
            return Arr;
        }
    }
}
