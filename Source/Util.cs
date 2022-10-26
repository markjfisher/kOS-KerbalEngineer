using kOS.Suffixed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kOS.AddOns.kOSKerbalEngineer
{
    /// <summary>
    /// Everyone needs a util class
    /// </summary>
    public class Util
    {
        ///<summary>
        /// checks if the mod with "assemblyName" is loaded into KSP.
        ///</summary>
        public static bool IsModInstalled(string assemblyName)
        {
            return AssemblyLoader.loadedAssemblies.Contains(assemblyName);
        }

        private static AssemblyLoader.LoadedAssembly FindLoadedAssembly(string assemblyName)
        {
            return (from a in AssemblyLoader.loadedAssemblies
                    where a.name.ToLower().Equals(assemblyName.ToLower())
                    select a).FirstOrDefault();
        }

        /// <summary>
        /// Returns Version of named assembly, or null if it doesn't exist
        /// </summary>
        /// <param name="assemblyName">The assembly name to return version of</param>
        /// <returns></returns>
        public static Version AssemblyVersion(string assemblyName)
        {
            if (!IsModInstalled(assemblyName)) return null;
            return FindLoadedAssembly(assemblyName).assembly.GetName().Version;
        }
    }
}
