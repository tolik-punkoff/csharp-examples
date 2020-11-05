using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HelloWorldConsole
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show("This is example program.", "Hello, world",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}