using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using System.Security;
using System.Security.Permissions;
using System.Runtime.Remoting;
using System.Reflection;

namespace Sandbox_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApplicationBrowse_Click(object sender, EventArgs e)
        {
            DialogResult appDialogResult = openApplicationDialog.ShowDialog();

            if (DialogResult.OK == appDialogResult)
            {
                txtApplicationPath.Text = openApplicationDialog.FileName;
            }
        }

        private void btnToggleAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckState.Checked == btnToggleAdvanced.CheckState)
            {
                lblApplicationParam.Visible = true;
                txtApplicationParam.Visible = true;
            }
            else
            {
                lblApplicationParam.Visible = false;
                txtApplicationParam.Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string appFilePath = txtApplicationPath.Text;
            string[] appFileParam = txtApplicationParam.Text.Split(' ');
            string appAssemblyName = Path.GetFileNameWithoutExtension(txtApplicationPath.Text);

            Evidence ev = new Evidence();
            ev.AddHostEvidence(new Zone(SecurityZone.MyComputer));

            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = Path.GetDirectoryName(appFilePath);

            PermissionSet permSet = SecurityManager.GetStandardSandbox(ev);
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));

            StrongName fullTrustAssembly = typeof(Sandboxer).Assembly.Evidence.GetHostEvidence<StrongName>();

            AppDomain newDomain = AppDomain.CreateDomain("Sandbox", ev, adSetup, permSet, fullTrustAssembly);

            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain,
                typeof(Sandboxer).Assembly.ManifestModule.FullyQualifiedName,
                typeof(Sandboxer).FullName);

            Sandboxer newDomainInstance = (Sandboxer)handle.Unwrap();
            newDomainInstance.ExecuteUntrustedCode(appAssemblyName, appFileParam);
        }
    }
}
