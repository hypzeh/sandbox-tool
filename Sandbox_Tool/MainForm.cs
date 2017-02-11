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
        }

        public void LogThis(string logString)
        {
            txtLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + logString + "\n");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string appFilePath = txtApplicationPath.Text;
            string[] appFileParam = txtApplicaitonParam.Text.Split(' ');
            string appAssemblyName = Path.GetFileNameWithoutExtension(txtApplicationPath.Text);

            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = Path.GetDirectoryName(appFilePath);

            PermissionSet permSet = checkUnrestricted.CheckState == CheckState.Checked
                ? new PermissionSet(PermissionState.Unrestricted) : new PermissionSet(PermissionState.None);

            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
            permSet.AddPermission(new ReflectionPermission(PermissionState.Unrestricted));

            permSet.AddPermission(checkIO.CheckState == CheckState.Checked ?
                new FileIOPermission(PermissionState.Unrestricted) : new FileIOPermission(PermissionState.None));


            StrongName fullTrustAssembly = typeof(Sandboxer).Assembly.Evidence.GetHostEvidence<StrongName>();

            Random rnd = new Random();
            AppDomain newDomain = AppDomain.CreateDomain("Sandbox" + rnd.Next().ToString(), null, adSetup, permSet, fullTrustAssembly);

            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain,
                typeof(Sandboxer).Assembly.ManifestModule.FullyQualifiedName,
                typeof(Sandboxer).FullName);

            Sandboxer newDomainInstance = (Sandboxer)handle.Unwrap();
            try
            {
                LogThis("Executing...");
                newDomainInstance.ExecuteUntrustedCode(appAssemblyName, appFileParam);
                LogThis("Application ended successfully.");
            }
            catch (SecurityException ex)
            {
                // When we print informations from a SecurityException extra information can be printed if we are 
                //calling it with a full-trust stack.
                (new PermissionSet(PermissionState.Unrestricted)).Assert();
                Console.WriteLine("SecurityException caught:\n{0}", ex.ToString());
                LogThis("ERROR : " + ex.Action.ToString());
                if (ex.Action.ToString() == "Demand")
                {
                    LogThis(Regex.Replace(ex.Demanded.ToString(), @"\t|\n|\r", " "));
                }
                CodeAccessPermission.RevertAssert();
            }
        }

        private void btnLogTest_Click(object sender, EventArgs e)
        {
            LogThis("TEST");
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

        private void txtApplicationPath_TextUpdate(object sender, EventArgs e)
        {
            if (txtApplicationPath.Text.Length > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }
    }
}
