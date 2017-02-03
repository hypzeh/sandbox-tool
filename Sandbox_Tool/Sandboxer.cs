using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace Sandbox_Tool
{
    class Sandboxer : MarshalByRefObject
    {
        public void ExecuteUntrustedCode(string assemblyName)
        {
            //Load the MethodInfo for a method in the new Assembly. This might be a method you know, or 
            //you can use Assembly.EntryPoint to get to the main function in an executable.
            MethodInfo target = Assembly.Load(assemblyName).EntryPoint;

            try
            {
                //Now invoke the method.         
                bool retVal = (bool)target.Invoke(null, null);
            }
            catch (Exception ex)
            {
                // When we print informations from a SecurityException extra information can be printed if we are 
                //calling it with a full-trust stack.
                (new PermissionSet(PermissionState.Unrestricted)).Assert();
                Console.WriteLine("SecurityException caught:\n{0}", ex.ToString());
                CodeAccessPermission.RevertAssert();
            }
        }
    }
}
