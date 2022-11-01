using KerbalEngineer.Flight.Readouts.Thermal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kOS.AddOns.kOSKerbalEngineer.Vessel
{
    /// <summary>
    /// Thermal data
    /// </summary>
    public static class Thermal
    {
        /// <summary>
        /// The name of the part that is structually most critical.
        /// </summary>
        /// <returns>String name of part most critical</returns>
        public static string CriticalPartName()
        {
            ThermalProcessor.RequestUpdate();
            return ThermalProcessor.CriticalPartName;
        }

        /// <summary>
        /// Internal Temperature on the part of the Vessel that is structually most critical.
        /// </summary>
        /// <returns>Temperature as double</returns>
        public static double CriticalTemperature()
        {
            ThermalProcessor.RequestUpdate();
            return ThermalProcessor.CriticalTemperature;
        }

        /// <summary>
        /// Maximum Internal Temperature of the part of the Vessel that is structually most critical.
        /// </summary>
        /// <returns>Max Temperature as double</returns>
        public static double CriticalTemperatureMax()
        {
            ThermalProcessor.RequestUpdate();
            return ThermalProcessor.CriticalTemperatureMax;
        }

        /// <summary>
        /// How high a temperature the critical Part is enduring relative to it's maximal temperature.
        /// </summary>
        /// <returns>Percentage as double between 0 and 100</returns>
        public static double CriticalThermalPercentage()
        {
            ThermalProcessor.RequestUpdate();
            return ThermalProcessor.CriticalTemperaturePercentage * 100.0;
        }

        /// <summary>
        /// Highest external Temperature on the part of the Vessel that is structually most critical.
        /// </summary>
        /// <returns>Temperature as double</returns>
        public static double CriticalSkinTemperature()
        {
            ThermalProcessor.RequestUpdate();
            return ThermalProcessor.CriticalSkinTemperature;
        }

        /// <summary>
        /// Max Highest external Temperature on the part of the Vessel that is structually most critical.
        /// </summary>
        /// <returns>Temperature as double</returns>
        public static double CriticalSkinTemperatureMax()
        {
            ThermalProcessor.RequestUpdate();
            return ThermalProcessor.CriticalSkinTemperatureMax;
        }


    }
}
