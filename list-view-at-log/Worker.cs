using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewTest
{
    public class WorkerEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
    class Worker
    {
        public delegate void OnStatusChanged(object sender, WorkerEventArgs e);
        public event OnStatusChanged StatusChanged;

        private void SendMessage(string stMessage)
        {
            WorkerEventArgs e = new WorkerEventArgs();
            e.Message = stMessage;
            if (StatusChanged != null) StatusChanged(this, e);

        }

        private void Process()
        {
            int StartCount = 0;
            int EndCount = 500;

            for (int i = StartCount; i<EndCount; i++)
            {
                SendMessage(i.ToString());
            }
        }

        public void StartProcess()
        {
            System.Threading.Thread getcfgThread =
                new System.Threading.Thread(Process);
            getcfgThread.Start();
        }
    }
}
