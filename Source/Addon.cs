using kOS.Safe.Utilities;
using kOS.Safe.Encapsulation;
using kOS.Safe.Encapsulation.Suffixes;
using kOS.Suffixed;

namespace kOS.AddOns.kOSKerbalEngineer
{
    using info;
    using KerbalEngineer.Flight.Readouts.Orbital.ManoeuvreNode;
    using kOS.AddOns.kOSKerbalEngineer.ManoeuvreNode;
    using kOS.AddOns.kOSKerbalEngineer.Vessel;

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
            AddSuffix("nodeHalfBurnTime", new NoArgsSuffix<ScalarDoubleValue>(() => BurnTime.NodeHalfBurnTime()));
            AddSuffix("nodeBurnTime", new NoArgsSuffix<ScalarDoubleValue>(() => BurnTime.NodeBurnTime()));

            // suicide burn values
            AddSuffix("suicideBurnCountdown", new NoArgsSuffix<ScalarDoubleValue>(() => SuicideBurn.Countdown()));
            AddSuffix("suicideBurnDeltaV", new NoArgsSuffix<ScalarDoubleValue>(() => SuicideBurn.DeltaV()));
            AddSuffix("suicideBurnLength", new NoArgsSuffix<ScalarDoubleValue>(() => SuicideBurn.Length()));
            AddSuffix("suicideBurnDistance", new NoArgsSuffix<ScalarDoubleValue>(() => SuicideBurn.Distance()));
            AddSuffix("suicideBurnAltitude", new NoArgsSuffix<ScalarDoubleValue>(() => SuicideBurn.Altitude()));

            // TWR
            AddSuffix("actualTWR", new NoArgsSuffix<ScalarDoubleValue>(() => ThrustToWeight.Actual()));
            AddSuffix("totalTWR", new NoArgsSuffix<ScalarDoubleValue>(() => ThrustToWeight.Total()));

            // Thermal
            AddSuffix("criticalPartName", new NoArgsSuffix<StringValue>(() => Thermal.CriticalPartName()));
            AddSuffix("criticalTemperature", new NoArgsSuffix<ScalarDoubleValue>(() => Thermal.CriticalTemperature()));
            AddSuffix("criticalTemperatureMax", new NoArgsSuffix<ScalarDoubleValue>(() => Thermal.CriticalTemperatureMax()));
            AddSuffix("criticalThermalPercentage", new NoArgsSuffix<ScalarDoubleValue>(() => Thermal.CriticalThermalPercentage()));
            AddSuffix("criticalSkinTemperature", new NoArgsSuffix<ScalarDoubleValue>(() => Thermal.CriticalSkinTemperature()));
            AddSuffix("criticalSkinTemperatureMax", new NoArgsSuffix<ScalarDoubleValue>(() => Thermal.CriticalSkinTemperatureMax()));

        }

        #region suffix_functions
        #endregion

    }
}