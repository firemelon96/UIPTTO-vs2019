using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace UIPTTO_DATABASE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new loginRegister.loginForm());
        }
    }
}