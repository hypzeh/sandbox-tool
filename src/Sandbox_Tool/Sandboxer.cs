using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Tool
{
    class Sandboxer : MarshalByRefObject
    {
        public void ApplicationInitialise(string txtAppPath, string txtAppParam, PermissionSet permSet)
        {
            string appFilePath = Path.GetDirectoryName(txtAppPath);
            string[] appFileParam = txtAppParam.Split(' ');
            string appAssemblyName = Path.GetFileNameWithoutExtension(txtAppPath);

            // Application Domain Setup
            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = appFilePath;

            // Strong Name using 'Sandboxer_Key.snk'
            StrongName fullTrustAssembly = typeof(Sandboxer).Assembly.Evidence.GetHostEvidence<StrongName>();

            // Create Application Domain with a random 'ID' value so not all sandbox domains are the same
            Random rnd = new Random();
            AppDomain newDomain = AppDomain.CreateDomain("Sandbox" + rnd.Next().ToString(), null, adSetup, permSet, fullTrustAssembly);

            // Object handle
            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain,
                typeof(Sandboxer).Assembly.ManifestModule.FullyQualifiedName,
                typeof(Sandboxer).FullName);

            // Execute Application code
            Sandboxer newDomainInstance = (Sandboxer)handle.Unwrap();
            Console.WriteLine("--- {0} STARTED ---", appAssemblyName);
            newDomain.ExecuteAssembly(txtAppPath, appFileParam);
            Console.WriteLine("--- {0} FINISHED ---\n", appAssemblyName);
        }
    }
}
