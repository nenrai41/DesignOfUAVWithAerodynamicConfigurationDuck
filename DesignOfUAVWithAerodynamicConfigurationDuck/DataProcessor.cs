using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    public class DataProcessor
    {
        private static DataProcessor calculateObject;

        private DataProcessor()
        { }

        public static DataProcessor GetCalculateObject()
        {
            if (calculateObject == null)
                calculateObject = new DataProcessor();
            return calculateObject;
        }

        public float StartingMass { get; private set; }             
        public void CalculateOfStartingMass (float payloadMass, float relativePayloadMass)
        {
            StartingMass =  payloadMass / relativePayloadMass;
        }

    }
}
