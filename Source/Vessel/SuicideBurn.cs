using KerbalEngineer.Flight.Readouts.Surface;

namespace kOS.AddOns.kOSKerbalEngineer.Vessel
{
    /// <summary>
    /// Suicide Burn Calculations
    /// </summary>
    public static class SuicideBurn
    {
        /// <summary>
        /// Gets time until suicide burn should start
        /// </summary>
        /// <returns>Suicide Countdown Time as double</returns>
        public static double Countdown()
        {
            PerformUpdates();
            return ImpactProcessor.SuicideCountdown;
        }

        /// <summary>
        /// Gets the DeltaV of a suicide burn
        /// </summary>
        /// <returns>The suicide burn deltaV as double</returns>
        public static double DeltaV()
        {
            PerformUpdates();
            return ImpactProcessor.SuicideDeltaV;
        }

        /// <summary>
        /// Gets the duration of the suicide burn
        /// </summary>
        /// <returns>The suicide burn duration as double</returns>
        public static double Length()
        {
            PerformUpdates();
            return ImpactProcessor.SuicideLength;
        }

        /// <summary>
        /// Gets the distance to the point at which to start a suicide burn
        /// </summary>
        /// <returns>The suicide burn Distance as double</returns>
        public static double Distance()
        {
            PerformUpdates();
            return ImpactProcessor.SuicideDistance;
        }

        /// <summary>
        /// Gets the sea level altitude when to start a suicide burn
        /// </summary>
        /// <returns>The suicide burn Altitude (from sea level) as double</returns>
        public static double Altitude()
        {
            PerformUpdates();
            return ImpactProcessor.SuicideAltitude;
        }

        private static void PerformUpdates()
        {
            ImpactProcessor.RequestUpdate();
            ImpactProcessor.Instance.Update();
        }
    }
}
