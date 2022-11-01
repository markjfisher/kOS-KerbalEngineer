using KerbalEngineer.Flight.Readouts.Orbital.ManoeuvreNode;

namespace kOS.AddOns.kOSKerbalEngineer.ManoeuvreNode
{
    /// <summary>
    /// Burn Time calculations
    /// </summary>
    public static class BurnTime
    {
        /// <summary>
        /// Returns the "Half" Burn Time for the next node.
        /// </summary>
        /// <returns>A double representing the time for half the burn.</returns>
        public static double NodeHalfBurnTime()
        {
            ManoeuvreProcessorPerformUpdates();
            return ManoeuvreProcessor.HalfBurnTime;
        }

        /// <summary>
        /// Returns the Full Burn Time for the next node.
        /// </summary>
        /// <returns>A double representing the time for the full burn of the node.</returns>
        public static double NodeBurnTime()
        {
            ManoeuvreProcessorPerformUpdates();
            return ManoeuvreProcessor.BurnTime;
        }


        private static void ManoeuvreProcessorPerformUpdates()
        {
            ManoeuvreProcessor.RequestUpdate();
            ManoeuvreProcessor.Instance.Update();

        }
    }
}
