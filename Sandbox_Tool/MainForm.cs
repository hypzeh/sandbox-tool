using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Sandbox_Tool
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        string appFilePath          = "None";
        DialogResult appFileResult  = DialogResult.None;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnApplicationBrowse_Click(object sender, EventArgs e)
        {
            appFileResult = openApplicationFile.ShowDialog();

            if (appFileResult == DialogResult.OK)
            {
                appFilePath                 = openApplicationFile.FileName;
                txtBoxApplicationPath.Text  = appFilePath;
            }
            else
            {
                Console.WriteLine("Failed: Open Application");
            }
        }
    }
}
