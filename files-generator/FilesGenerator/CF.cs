using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace FilesGenerator
{
    public static class CF
    {
        [DllImport("msvcrt.dll",
        EntryPoint = "memset",
        CallingConvention = CallingConvention.Cdecl,
        SetLastError = false)]

        private static extern IntPtr MemSet(IntPtr dest, int value, int count);

        private static string AddSlash(string st)
        {
            if (st.EndsWith("\\"))
            {
                return st;
            }

            return st + "\\";
        }

        private static byte[] FillBytes(int Length, byte Value)
        {
            byte[] Arr = new byte[Length];
            GCHandle GCH = GCHandle.Alloc(Arr, GCHandleType.Pinned);
            MemSet(GCH.AddrOfPinnedObject(), (int)Value, Length);
            return Arr;
        }

        private static byte[] FillRandomBytes(int Length)
        {
            byte[] Arr = new byte[Length];
            RNGCryptoServiceProvider RngCsp = new RNGCryptoServiceProvider();
            RngCsp.GetBytes(Arr);
            return Arr;
        }

        public static ulong ToBytes(ulong bytes, string modificator)
        {
            ulong Ret = 0;
            switch (modificator)
            {
                case "":
                    {
                        Ret = bytes;
                    } break;
                case "K":
                case "k":
                    {
                        Ret = bytes * 1024;
                    } break;
                case "M":
                case "m":
                    {
                        Ret = bytes * 1024 * 1024;
                    } break;
                case "G":
                case "g":
                    {
                        Ret = bytes * 1024 * 1024 * 1024;
                    } break;
                default:
                    {
                        throw new ArgumentException("Wrong modificator ["
                            + modificator + "]. Set K(k), M(m), G(g)");
                    }                    
            }

            return Ret;
        }

        
        private static int CountDigitsRec(ulong n)
        {            
            if (n <= 9)
            {
                return 1;
            }
            else
            {
                return CountDigitsRec(n / 10) + 1;
            }
        }



        public static void GenFiles(ulong FilesCount, ulong FileSize,
            bool RandomName, string Extension, bool RandomBytes, byte BytePattern)
        {
            string FormatPattern = "{0:d" +
                CountDigitsRec(FilesCount).ToString() + "}";
            int MaxBuf = 1048576; //Max Buffer size == 1Mb
            ulong BufSize = 0;
            if (FileSize <= (ulong)MaxBuf) 
            {
                BufSize = FileSize;
            }
            else
            {
                BufSize = (ulong)MaxBuf;
            }

            byte[] WriteBuf = new byte[BufSize];

            if (!RandomBytes||(BytePattern != 0x00))
            {
                WriteBuf = FillBytes((int)BufSize, BytePattern);
            }
            
            //Generate Files...
            Console.WriteLine("Genering files:");
            int posLeft = 0;
            int posTop = 0;
            string CurDir = AddSlash(Environment.CurrentDirectory);

            string FileName = "";
            for (ulong i = 1; i <= FilesCount; i++)
            {

                if (!RandomName) //Set file name
                {
                    FileName = String.Format(FormatPattern, i) + "." + Extension;
                }
                else
                {
                    FileName = Path.GetRandomFileName();
                }

                ulong RealSize = FileSize;
                FileStream fs = null;               
                
                // Open File Stream
                try
                {
                    fs = new FileStream(CurDir + FileName, FileMode.Create,
                        FileAccess.Write);
                }
                catch (Exception ex)
                {
                    if (fs != null) fs.Close();
                    Console.WriteLine("ERROR WRITE FILE: " + FileName);
                    Console.WriteLine(ex.Message);
                    return;
                }

                
                while (RealSize > (ulong)MaxBuf)
                {
                    if (RandomBytes)
                    {
                        WriteBuf = FillRandomBytes((int)BufSize);
                    }

                    //write full buffer
                    try
                    {
                        fs.Write(WriteBuf, 0, (int)BufSize);
                    }
                    catch (Exception ex)
                    {
                        if (fs != null) fs.Close();
                        Console.WriteLine("ERROR WRITE FILE: " + FileName);
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    RealSize = RealSize - (ulong)MaxBuf;
                }

                if (RandomBytes)
                {
                    WriteBuf = FillRandomBytes((int)BufSize);
                }

                //write last bytes
                if (RealSize > 0)
                {
                    try
                    {
                        fs.Write(WriteBuf, 0, (int)RealSize);
                    }
                    catch (Exception ex)
                    {
                        if (fs != null) fs.Close();
                        Console.WriteLine("ERROR WRITE FILE: " + FileName);
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                //Close FileStream
                fs.Close();
                
                posTop = Console.CursorTop;
                string WriteStr = String.Format(FormatPattern, i) + " / " + FilesCount;
                Console.SetCursorPosition(posLeft, posTop);
                Console.Write(WriteStr);
            }
            //end for
        }
    }
}
