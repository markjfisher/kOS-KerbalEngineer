using kOS.Safe.Utilities;
using kOS.Safe.Encapsulation;
using kOS.Safe.Encapsulation.Suffixes;
using kOS.Suffixed;

namespace kOS.AddOns.kOSKerbalEngineer
{
    using info;
    using KerbalEngineer.Flight.Readouts.Orbital.ManoeuvreNode;

    /// <summary>
    /// kOS integration for KerbalEngineer
    /// </summary>
    [kOSAddon("ke")]
    [KOSNomenclature("KerbalEngineerAddon")]
    public class KOSKerbalEngineerAddon : Addon
    {
        /// <summary>
        /// The Addon's name.
        /// </summary>
        public const string Name = "kOS-KerbalEngineer";

        /// <summary>
        /// The class initializer
        /// </summary>
        /// <param name="shared">The shared objects</param>
        public KOSKerbalEngineerAddon(SharedObjects shared) : base(shared)
        {
            InitializeSuffixes();
        }

        /// <inheritdoc/>
        public override BooleanValue Available() => Util.IsModInstalled("Astrogator") && Util.IsModInstalled("KerbalEngineer");

        private void InitializeSuffixes()
        {
            // info
            AddSuffix("help", new NoArgsVoidSuffix(() => Help.PrintHelp(shared)));
            AddSuffix("version", new NoArgsSuffix<StringValue>(() => Version.GetVersion()));

            // burn info
            AddSuffix("nodeHalfBurnTime", new NoArgsSuffix<ScalarDoubleValue>(() =>
            {
                ManoeuvreProcessor.RequestUpdate();
                ManoeuvreProcessor proc = ManoeuvreProcessor.Instance;
                proc.Update();
                return ManoeuvreProcessor.HalfBurnTime;
            }));
            AddSuffix("nodeBurnTime", new NoArgsSuffix<ScalarDoubleValue>(() =>
            {
                ManoeuvreProcessor.RequestUpdate();
                ManoeuvreProcessor proc = ManoeuvreProcessor.Instance;
                proc.Update();
                return ManoeuvreProcessor.BurnTime;
            }));
        }

        #region suffix_functions
        #endregion

    }
}