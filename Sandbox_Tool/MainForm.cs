using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private PermissionSet pSet()
        {
            PermissionSet permSet = checkUnrestricted.CheckState == CheckState.Checked
                ? new PermissionSet(PermissionState.Unrestricted) : new PermissionSet(PermissionState.None);

            // Default Permissions required by assembly
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read, txtApplicationPath.Text));
            permSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.PathDiscovery, txtApplicationPath.Text));

            // Chosen Permissions
            permSet.AddPermission(checkIO.CheckState == CheckState.Checked ?
                new FileIOPermission(PermissionState.Unrestricted) : new FileIOPermission(PermissionState.None));

            permSet.AddPermission(checkUI.CheckState == CheckState.Checked ?
                new UIPermission(PermissionState.Unrestricted) : new UIPermission(PermissionState.None));

            permSet.AddPermission(checkFileDialog.CheckState == CheckState.Checked ?
                new FileDialogPermission(PermissionState.Unrestricted) : new FileDialogPermission(PermissionState.None));

            permSet.AddPermission(checkSecurity.CheckState == CheckState.Checked ?
                new SecurityPermission(PermissionState.Unrestricted) : new SecurityPermission(PermissionState.None));

            permSet.AddPermission(checkIsolatedStorage.CheckState == CheckState.Checked ?
                new IsolatedStorageFilePermission(PermissionState.Unrestricted) : new IsolatedStorageFilePermission(PermissionState.None));

            permSet.AddPermission(checkEnvironment.CheckState == CheckState.Checked ?
                new EnvironmentPermission(PermissionState.Unrestricted) : new EnvironmentPermission(PermissionState.None));

            permSet.AddPermission(checkKeyContainer.CheckState == CheckState.Checked ?
                new KeyContainerPermission(PermissionState.Unrestricted) : new KeyContainerPermission(PermissionState.None));

            permSet.AddPermission(checkPrincipal.CheckState == CheckState.Checked ?
                new PrincipalPermission(PermissionState.Unrestricted) : new PrincipalPermission(PermissionState.None));

            permSet.AddPermission(checkReflection.CheckState == CheckState.Checked ?
                new ReflectionPermission(PermissionState.Unrestricted) : new ReflectionPermission(PermissionState.None));

            permSet.AddPermission(checkReflection.CheckState == CheckState.Checked ?
                new RegistryPermission(PermissionState.Unrestricted) : new RegistryPermission(PermissionState.None));

            permSet.AddPermission(checkStore.CheckState == CheckState.Checked ?
                new StorePermission(PermissionState.Unrestricted) : new StorePermission(PermissionState.None));

            permSet.AddPermission(checkTypeDescriptor.CheckState == CheckState.Checked ?
                new TypeDescriptorPermission(PermissionState.Unrestricted) : new TypeDescriptorPermission(PermissionState.None));

            permSet.AddPermission(checkWeb.CheckState == CheckState.Checked ?
                new WebPermission(PermissionState.Unrestricted) : new WebPermission(PermissionState.None));

            return permSet;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Sandboxer appSandbox = new Sandboxer();

            LogThis("Executing " + Path.GetFileName(txtApplicationPath.Text));
            try
            {
                appSandbox.ApplicationInitialise(txtApplicationPath.Text, txtApplicaitonParam.Text, pSet());
            }
            catch (SecurityException ex)
            {
                LogThis("ERROR : " + ex.Action.ToString());
                Console.WriteLine("--- {0} ERROR ---\n", Path.GetFileNameWithoutExtension(txtApplicationPath.Text));
                if (ex.Action.ToString() == "Demand")
                {
                    int cutPoint = ex.Message.ToString().IndexOf(",");
                    LogThis("DEMAND : " + ex.Message.ToString().Substring(0, cutPoint) + "'");
                }
            }


            LogThis("Terminated " + Path.GetFileName(txtApplicationPath.Text));
            ManageHistory();
            LogThis("Ready...");
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

        private void btnLogToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLogToggle.CheckState == CheckState.Checked)
            {
                btnLogToggle.Text = "Hide Log";
                tableLog.Visible = true;
            }
            else
            {
                btnLogToggle.Text = "Show Log";
                tableLog.Visible = false;
            }
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            txtLog.ResetText();
        }

        private void toolTip_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Info: \n" + ((CheckBox)sender).Tag.ToString();
        }

        private void toolTip_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Info: \n" + "...";
        }
    }
}
