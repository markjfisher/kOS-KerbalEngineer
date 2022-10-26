namespace kOS.AddOns.kOSKerbalEngineer.info
{
    /// <summary>
    /// Help command
    /// </summary>
    public static class Help
    {
        /// <summary>
        /// The help command
        /// </summary>
        /// <param name="shared">The shared data</param>
        public static void PrintHelp(SharedObjects shared)
        {
            shared.Screen.Print("--------------------------------------------");
            shared.Screen.Print(Version.GetVersion());
            shared.Screen.Print("Usage: addons:ke:<cmd>");
            shared.Screen.Print("See https://github.com/markjfisher/kOS-KerbalEngineer/blob/master/GameData/kOS-KerbalEngineer/README.md");
            shared.Screen.Print("for full command details.");
            shared.Screen.Print("--------------------------------------------");
        }
    }
}
