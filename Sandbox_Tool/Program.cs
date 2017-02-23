using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1 || args.Contains("-h"))
            {
                var cmdMainForm = new MainForm();
                cmdMainForm.cmdManage(args);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
