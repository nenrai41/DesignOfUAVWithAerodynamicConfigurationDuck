using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    public static class ManipulationClass
    {
        public static float ConvertTo(string value)
        {
            if (float.TryParse(value, out float _value))
                return _value;
            else
                return 0;
        }
    }
}
