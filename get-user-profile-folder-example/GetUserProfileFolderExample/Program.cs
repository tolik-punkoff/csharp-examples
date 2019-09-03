using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GetUserProfileFolderExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string UserProfile = Environment.GetEnvironmentVariable("USERPROFILE");

            MessageBox.Show(UserProfile, "User profile folder path",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
