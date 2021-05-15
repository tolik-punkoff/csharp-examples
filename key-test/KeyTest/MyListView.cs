using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyTest
{
    class MyListView:ListView
    {
        public MyListView()
        {            
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);            
         //   this.SetStyle(ControlStyles.EnableNotifyMessage, true); 
        }
    }
}
