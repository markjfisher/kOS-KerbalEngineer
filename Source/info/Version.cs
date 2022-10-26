using System.Reflection;

namespace kOS.AddOns.kOSKerbalEngineer.info
{
    /// <summary>
    /// Deals with Version information
    /// </summary>
    public static class Version
    {
        private static readonly System.Version modVersion = Assembly.GetExecutingAssembly().GetName().Version;
        private static readonly System.Version keVersion = Util.AssemblyVersion("KerbalEngineer");


        /// <summary>
        /// Create a formatted version string for the mod.
        /// </summary>
        /// <returns></returns>
        public static string GetVersion() => string.Format(
            "kOS-KerbalEngineer: v{0}.{1}.{2}, KerbalEngineer: v{3}.{4}.{5}", 
            modVersion.Major, modVersion.Minor, modVersion.Build,
            keVersion.Major, keVersion.Minor, keVersion.Build
        );
    }
}
