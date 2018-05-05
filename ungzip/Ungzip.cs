using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace tmpAnalyseRP5
{
    public class Ungzip
    {
        public string ErrorMessage { get; private set; }
        public bool IsGZip(string filename)
        {
            byte[] buf = null;
            try
            {
                buf = File.ReadAllBytes(filename);
            }
            catch
            {
                return false;
            }

            if (buf.Length < 4) return false;

            if ((buf[0] == 0x1F) && (buf[1] == 0x8B) &&
                (buf[2] == 0x08) && (buf[3] == 0x00))
                return true;

            return false;
        }

        public string GetUnpackedFilename(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            string unpackedFile = fileName.Substring(0, fileName.Length - fi.Extension.Length);
            return unpackedFile;
        }

        public bool Unpack(string originalFile, string unpackedFile)
        {            
            GZipStream gzip = null;
            FileStream readStream = null;
            FileStream writeStream = null;

            try
            {
                readStream = new FileStream(originalFile, FileMode.Open);               
                writeStream = new FileStream(unpackedFile, FileMode.Create);         
                gzip = new GZipStream(readStream,CompressionMode.Decompress);

                int size = 1024; //размер буфера для обмена между потоками
                byte[] unpackbuf = new byte[size]; //буфер                
                int count = 0; //для хранения фактически прочитанных байт
                
                //пишем распакованные данные по кускам
                do
                {
                    count = gzip.Read(unpackbuf, 0, size); //читаем кусками размером size
                    if (count > 0) //если данные есть
                    {                        
                        writeStream.Write(unpackbuf, 0, count); //пишем фактически 
                        //прочитанное кол-во байт
                    }
                } while (count > 0);                
            }
            catch (Exception ex)
            {
                if (readStream != null) readStream.Close();
                if (writeStream != null) writeStream.Close();
                if (gzip != null) gzip.Close();
                ErrorMessage = ex.Message;

                return false;
            }
            
            gzip.Close();
            readStream.Close();
            writeStream.Close();
            return true;
        }
    }
}
