using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace tmpCodeTable
{
    public static class EncodingHelper
    {

        public static List<UnicodeBlock> UnicodeBlocks =
            new List<UnicodeBlock>();        

        private static string BlocksURL = "http://www.unicode.org/Public/UNIDATA/Blocks.txt";
        private static string  BlocksFileName = Path.GetTempFileName();
        private static WebClient Downloader = new WebClient();        

        public static bool IsUnicode(int CodePage)
        {

            if (CodePage == 65001 ||
                CodePage == 65000 ||
                CodePage == 1201 ||
                CodePage == 1200 ||
                CodePage == 12000 ||
                CodePage == 12001)
                return true;
            else return false;            
        }
        
        private static bool GetUnicodeBlocksFile(bool TryWeb, bool WebOnly)
        {
            if (TryWeb)
            {
                try
                {
                    Downloader.DownloadFile(BlocksURL, BlocksFileName);
                }
                catch
                {
                    
                    if (WebOnly) return false;
                }
            }

            //get from resources
            string  buf = Properties.Resources.Blocks;
            try
            {
                File.WriteAllText(BlocksFileName, buf);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool GetUnicodeBlocks(bool TryWeb, bool WebOnly)
        {
            if (!GetUnicodeBlocksFile(TryWeb, WebOnly)) return false;

            string[] BlocksStrings = null;

            try
            {
                BlocksStrings=File.ReadAllLines(BlocksFileName);
            }
            catch
            {
                return false;
            }

            foreach (string s in BlocksStrings)
            {
                if (s.Trim() == string.Empty) continue; //empty string
                if (s.Trim().StartsWith("#")) continue; //comment

                string[] splitbuf = s.Split(';');
                if (splitbuf.Length < 2) return false; //format error
                string blockname = splitbuf[1].Trim();
                
                splitbuf = splitbuf[0].Split(new string[] {".."}, 
                    StringSplitOptions.None);
                if (splitbuf.Length < 2) return false; //format error
                string start = splitbuf[0].Trim();
                string end = splitbuf[1].Trim();
                UnicodeBlock ub = new UnicodeBlock(
                    Convert.ToInt32(start,16), Convert.ToInt32(end,16),blockname);

                UnicodeBlocks.Add(ub);
            }

            try
            {
                File.Delete(BlocksFileName);
            }
            catch { }

            return true;
        }
    }
}
