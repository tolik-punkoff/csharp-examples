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
        

        private void frmEncInfo_Load(object sender, EventArgs e)
        {            

            grdEncodings.Columns.Add("EncodingName", "EncodingName");
            grdEncodings.Columns.Add("CP", "CP");
            grdEncodings.Columns.Add("DisplayName", "DisplayName");
            grdEncodings.Columns.Add("MaxBytes", "MaxBytes");
            grdEncodings.Columns.Add("SingleByte", "SingleByte");
            grdEncodings.Columns.Add("IsUnicode", "IsUnicode");

            EncodingInfo[] ei = Encoding.GetEncodings();
            foreach (EncodingInfo einfo in ei)
            {
                int cp = einfo.CodePage;
                string name = einfo.Name;
                string dn = einfo.DisplayName;
                int maxbyte = Encoding.GetEncoding(cp).GetMaxByteCount(1);
                bool singlebyte = Encoding.GetEncoding(cp).IsSingleByte;
                bool isunicode = EncodingHelper.IsUnicode(cp);

                grdEncodings.Rows.Add(name, cp, dn, maxbyte, singlebyte,isunicode);
            }
        }
    }
}

