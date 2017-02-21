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
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        public void ApplicationInitialise(string txtAppPath, string txtAppParam, PermissionSet permSet)
        {
            string appFilePath = Path.GetDirectoryName(txtAppPath);
            string[] appFileParam = txtAppParam.Split(' ');
            string appAssemblyName = Path.GetFileNameWithoutExtension(txtAppPath);

            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = appFilePath;

            StrongName fullTrustAssembly = typeof(Sandboxer).Assembly.Evidence.GetHostEvidence<StrongName>();

            Random rnd = new Random();
            AppDomain newDomain = AppDomain.CreateDomain("Sandbox" + rnd.Next().ToString(), null, adSetup, permSet, fullTrustAssembly);

            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain,
                typeof(Sandboxer).Assembly.ManifestModule.FullyQualifiedName,
                typeof(Sandboxer).FullName);

            Sandboxer newDomainInstance = (Sandboxer)handle.Unwrap();
            newDomainInstance.ExecuteUntrustedCode(appAssemblyName, appFileParam);
        }

        public void ExecuteUntrustedCode(string assemblyName, string[] appParam)
        {
            //Load the MethodInfo for a method in the new Assembly. This might be a method you know, or 
            //you can use Assembly.EntryPoint to get to the main function in an executable.
            MethodInfo target = Assembly.Load(assemblyName).EntryPoint;
            object[] appParamObject = new object[] { appParam };


            if (target.GetParameters().Length == 0)
            {
                appParamObject = null;
            }
            else
            {
                AllocConsole();
            }

            target.Invoke(null, appParamObject);

            Console.ReadLine();
            FreeConsole();
        }
    }
}
