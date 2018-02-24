using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NewLineDemo
{
    public static class RWFile
    {
        public static int CP = 28605;

        public static string ReadFile(string FileName)
        {           
            byte[] TempBuf = File.ReadAllBytes(FileName);
            
            string ReadBuf = "";
            StreamReader sr = new StreamReader(FileName, Encoding.GetEncoding(CP), false);
            ReadBuf=sr.ReadToEnd();
            sr.Close();
            return ReadBuf;
        }

        public static void WriteFile(string FileName, string FileData, bool Backup)
        {
            if (Backup)
            {
                File.Copy(FileName, FileName + ".bak", true);
            }
            StreamWriter sw = new StreamWriter(FileName, false, Encoding.GetEncoding(CP));
            sw.Write(FileData);
            sw.Close();
                        
        }
    }
}
