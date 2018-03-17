using System;
using System.Collections.Generic;
using System.Text;

namespace tmpCodeTable
{
    public class UnicodeBlock
    {
        public int Start { get; private set; }
        public int End { get; private set; }
        public string  StartHex { get; private set; }
        public string  EndHex { get; private set; }
        public int Length { get; private set; }
        public string  Desription { get; private set; }

        public UnicodeBlock(int start, int end, string desription)
        {
            Start = start;
            End = end;
            Desription = desription;

            StartHex = Convert.ToString(Start, 16).ToUpperInvariant().PadLeft(4,'0');
            EndHex = Convert.ToString(End, 16).ToUpperInvariant().PadLeft(4, '0');
            Length = End - Start;
        }

        public int PagesCount(int PageSize)
        {
            if (PageSize == 0) return 0;
            return Length / PageSize+1;
        }

        public int PageStart(int PageSize, int PageNumber)
        {
            if (PageNumber < 0) return -1;
            if (PageNumber >= PagesCount(PageSize)) return -1;
            if (PageSize >= Length) return Start;

            int start = Start + PageSize * PageNumber;
            if (start > End) return start = End;
            
            return start;
        }

        public int PageEnd(int PageSize, int PageNumber)
        {
            if (PageNumber < 0) return -1;
            if (PageNumber >= PagesCount(PageSize)) return -1;
            if (PageSize >= Length) return End;

            int end = Start + PageSize * PageNumber + PageSize;
            if (end > End) end = End;

            return end;
        }
    }
}
