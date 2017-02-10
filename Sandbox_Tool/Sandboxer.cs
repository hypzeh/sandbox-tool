using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Tool
{
    class Sandboxer : MarshalByRefObject
    {
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

            target.Invoke(null, appParamObject);
        }
    }
}
