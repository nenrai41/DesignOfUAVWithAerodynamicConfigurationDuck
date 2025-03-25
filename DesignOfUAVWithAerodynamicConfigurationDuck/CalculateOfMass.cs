using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    public class CalculateOfMass
    {
        public int StartingMass { get; set; }             
        public static double CalculateOfStartingMass (double payloadMass, double relativePayloadMass)
        {
            return payloadMass / relativePayloadMass;
        }

    }
}
