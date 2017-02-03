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
using System.Security.Policy;
using System.Security;
using System.Security.Permissions;
using System.Runtime.Remoting;
using System.Reflection;

namespace Sandbox_Tool
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        string appFilePath          = null;
        string appAssemblyName      = null;
        DialogResult appFileResult  = DialogResult.None;

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||MAIN FORM
        public MainForm()
        {
            InitializeComponent();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||APPLICATION BROWSER
        private void btnApplicationBrowse_Click(object sender, EventArgs e)
        {
            appFileResult = openApplicationFile.ShowDialog();

            if (appFileResult == DialogResult.OK)
            {
                txtBoxApplicationPath.Text  = openApplicationFile.FileName;
            }
            else
            {
                Console.WriteLine("Failed: Open Application");
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||BUTTON CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||BUTTON OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            appFilePath = txtBoxApplicationPath.Text;
            appAssemblyName = Path.GetFileNameWithoutExtension(txtBoxApplicationPath.Text);

            Evidence ev = new Evidence();
            ev.AddHostEvidence(new Zone(SecurityZone.MyComputer));

            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = Path.GetDirectoryName(appFilePath);

            PermissionSet permSet = SecurityManager.GetStandardSandbox(ev);
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new UIPermission(UIPermissionWindow.AllWindows)); // potentially
            permSet.AddPermission(new UIPermission(UIPermissionClipboard.AllClipboard)); // potentially

            StrongName fullTrustAssembly = typeof(Sandboxer).Assembly.Evidence.GetHostEvidence<StrongName>();

            AppDomain newDomain = AppDomain.CreateDomain("Sandbox", ev, adSetup, permSet, fullTrustAssembly);

            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain,
                typeof(Sandboxer).Assembly.ManifestModule.FullyQualifiedName,
                typeof(Sandboxer).FullName);

            Sandboxer newDomainInstance = (Sandboxer)handle.Unwrap();
            newDomainInstance.ExecuteUntrustedCode(appAssemblyName);

        }
    }
}
