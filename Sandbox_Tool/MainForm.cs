using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.ActiveControl = txtApplicationPath;
            UpdateHistory();

            LogThis("Choose Application...");
        }

        public void LogThis(string logString)
        {
            txtLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + logString + "\n");
        }

        public void UpdateHistory()
        {
            txtApplicationPath.Items.Clear();
            txtApplicationPath.Text = Sandbox_Tool.Properties.Settings.Default.appFilePathHistory1;
            txtApplicationPath.Items.Add(Sandbox_Tool.Properties.Settings.Default.appFilePathHistory2);
            txtApplicationPath.Items.Add(Sandbox_Tool.Properties.Settings.Default.appFilePathHistory3);
            txtApplicationPath.Items.Add(Sandbox_Tool.Properties.Settings.Default.appFilePathHistory4);
            txtApplicationPath.Items.Add(Sandbox_Tool.Properties.Settings.Default.appFilePathHistory5);
        }

        public void ManageHistory()
        {
            // Check for the next empty history string and add to history
            if (Sandbox_Tool.Properties.Settings.Default.appFilePathHistory1 == string.Empty)
            {
                Sandbox_Tool.Properties.Settings.Default.appFilePathHistory1 = txtApplicationPath.Text;
            }
            if (Sandbox_Tool.Properties.Settings.Default.appFilePathHistory2 == string.Empty)
            {
                Sandbox_Tool.Properties.Settings.Default.appFilePathHistory2 = txtApplicationPath.Text;
            }
            if (Sandbox_Tool.Properties.Settings.Default.appFilePathHistory3 == string.Empty)
            {
                Sandbox_Tool.Properties.Settings.Default.appFilePathHistory3 = txtApplicationPath.Text;
            }
            if (Sandbox_Tool.Properties.Settings.Default.appFilePathHistory4 == string.Empty)
            {
                Sandbox_Tool.Properties.Settings.Default.appFilePathHistory4 = txtApplicationPath.Text;
            }
            if (Sandbox_Tool.Properties.Settings.Default.appFilePathHistory5 == string.Empty)
            {
                Sandbox_Tool.Properties.Settings.Default.appFilePathHistory5 = txtApplicationPath.Text;
            }

            // Move each History item up and add the new item to the top/recent
            Sandbox_Tool.Properties.Settings.Default.appFilePathHistory5 = Sandbox_Tool.Properties.Settings.Default.appFilePathHistory4;
            Sandbox_Tool.Properties.Settings.Default.appFilePathHistory4 = Sandbox_Tool.Properties.Settings.Default.appFilePathHistory3;
            Sandbox_Tool.Properties.Settings.Default.appFilePathHistory3 = Sandbox_Tool.Properties.Settings.Default.appFilePathHistory2;
            Sandbox_Tool.Properties.Settings.Default.appFilePathHistory2 = Sandbox_Tool.Properties.Settings.Default.appFilePathHistory1;
            Sandbox_Tool.Properties.Settings.Default.appFilePathHistory1 = txtApplicationPath.Text;

            Sandbox_Tool.Properties.Settings.Default.Save();
            UpdateHistory();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            PermissionSet permSet = checkUnrestricted.CheckState == CheckState.Checked
                ? new PermissionSet(PermissionState.Unrestricted) : new PermissionSet(PermissionState.None);

            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new ReflectionPermission(PermissionState.Unrestricted));
            // UNMANGED CODE REQUIRED FOR ALLOCCONSOLE & FREECONSOLE
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));

            permSet.AddPermission(checkIO.CheckState == CheckState.Checked ?
                new FileIOPermission(PermissionState.Unrestricted) : new FileIOPermission(PermissionState.None));

            Sandboxer appSandbox = new Sandboxer();
            LogThis("Executing " + Path.GetFileName(txtApplicationPath.Text));
            try
            {
                appSandbox.ApplicationInitialise(txtApplicationPath.Text, txtApplicaitonParam.Text, permSet);
            }
            catch (SecurityException ex)
            {
                LogThis("ERROR : " + ex.Action.ToString());
                if (ex.Action.ToString() == "Demand")
                {
                    LogThis(Regex.Replace(ex.Demanded.ToString(), @"\t|\n|\r", " "));
                }
            }

            
            LogThis("Application Closed.");
            ManageHistory();

            //try
            //{
            //    LogThis("Executing...");
            //    newDomainInstance.ExecuteUntrustedCode(appAssemblyName, appFileParam);
            //    LogThis("Application ended successfully.");
            //}
            //catch (SecurityException ex)
            //{
            //    // When we print informations from a SecurityException extra information can be printed if we are 
            //    //calling it with a full-trust stack.
            //    (new PermissionSet(PermissionState.Unrestricted)).Assert();
            //    Console.WriteLine("SecurityException caught:\n{0}", ex.ToString());
            //    LogThis("ERROR : " + ex.Action.ToString());
            //    if (ex.Action.ToString() == "Demand")
            //    {
            //        LogThis(Regex.Replace(ex.Demanded.ToString(), @"\t|\n|\r", " "));
            //    }
            //    CodeAccessPermission.RevertAssert();
            //}
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult appDialogResult = openApplicaitonDialog.ShowDialog();

            if (DialogResult.OK == appDialogResult)
            {
                txtApplicationPath.Text = openApplicaitonDialog.FileName;
                btnOK.Enabled = true;
                LogThis(Path.GetFileName(txtApplicationPath.Text) + " selected.");
            }
        }
    }
}
