using KerbalEngineer.Flight.Readouts.Vessel;
using KerbalEngineer.VesselSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kOS.AddOns.kOSKerbalEngineer.Vessel
{
    /// <summary>
    /// Thrust to weight values
    /// </summary>
    public static class ThrustToWeight
    {
        /// <summary>
        /// Gets the vessel's actual thrust to weight ratio
        /// </summary>
        /// <returns>Actual TWR as double, 0 if there is no TWR</returns>
        public static double Actual()
        {
            if (SimulationProcessor.LastStage.totalMass > 0)
            {
                PerformUpdates();
                double gravity = FlightGlobals.getGeeForceAtPosition(FlightGlobals.ship_position).magnitude;
                return (SimulationProcessor.LastStage.actualThrust / (SimulationProcessor.LastStage.totalMass * gravity));
            } else
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the vessel's total thrust to weight ratio
        /// </summary>
        /// <returns>Total TWR as double, zero if there is no TWR</returns>
        public static double Total()
        {
            if (SimulationProcessor.LastStage.totalMass > 0)
            {
                PerformUpdates();
                double gravity = FlightGlobals.getGeeForceAtPosition(FlightGlobals.ship_position).magnitude;
                return (SimulationProcessor.LastStage.thrust / (SimulationProcessor.LastStage.totalMass * gravity));
            } else
            {
                return 0;
            }
        }


        private static void PerformUpdates()
        {
            SimulationProcessor.RequestUpdate();
        }
    }
}
