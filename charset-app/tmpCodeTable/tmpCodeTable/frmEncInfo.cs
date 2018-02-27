using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpCodeTable
{
    public partial class frmEncInfo : Form
    {
        public frmEncInfo()
        {
            InitializeComponent();
        }

        private string RemoveChar(string Str, char Chr)
        {
            string b = Str.Replace("\0", string.Empty);

            return b;
        }

        private byte[] GetByteArray(int Code, int Len)
        {
            byte[] Ret = new byte[Len];
            byte[] conv = BitConverter.GetBytes(Code);

            for (int i = 0; i < Len; i++)
            {
                Ret[i] = conv[i];
            }

            return Ret;
        }

        private void frmEncInfo_Load(object sender, EventArgs e)
        {
            //65001
            /*            int CP = 1251;
                        Encoding enc = Encoding.GetEncoding(CP); 
                        int maxbyte = enc.GetMaxByteCount(1);                            
            
                        string[] tbl = new string[maxbyte];

                        for (int i = 1; i <= maxbyte; i++)
                        {
                            for (Int64 j = 0; j < int.MaxValue; j++)
                            {
                                byte[] chrbuf = GetByteArray((int)j, i);
                                tbl[i]=tbl[i]+enc.GetString(chrbuf);
                            }
                        }

                        MessageBox.Show(char.MaxValue.ToString() + " ");*/
            //MessageBox.Show(i1251.ToString() + " ");

            grdEncodings.Columns.Add("EncodingName", "EncodingName");
            grdEncodings.Columns.Add("CP", "CP");
            grdEncodings.Columns.Add("MaxBytes", "MaxBytes");
            grdEncodings.Columns.Add("SingleByte", "SingleByte");

            EncodingInfo[] ei = Encoding.GetEncodings();
            foreach (EncodingInfo einfo in ei)
            {
                int cp = einfo.CodePage;
                string name = einfo.Name;
                int maxbyte = Encoding.GetEncoding(cp).GetMaxByteCount(1);
                bool singlebyte = Encoding.GetEncoding(cp).IsSingleByte;

                grdEncodings.Rows.Add(name, cp, maxbyte, singlebyte);
            }
        }
    }
}

//65001
/*int CP = 1251;
Encoding enc = Encoding.GetEncoding(CP); 
int maxbyte = enc.GetMaxByteCount(1);                            
            
string[] tbl = new string[maxbyte];

for (int i = 1; i <= maxbyte; i++)
{
    for (Int64 j = 0; j < int.MaxValue; j++)
    {
        byte[] chrbuf = GetByteArray((int)j, i);
        tbl[i]=tbl[i]+enc.GetString(chrbuf);
    }
}

MessageBox.Show(char.MaxValue.ToString() + " ");
//MessageBox.Show(i1251.ToString() + " ");*/

