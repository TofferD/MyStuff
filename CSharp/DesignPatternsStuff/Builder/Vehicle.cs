using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public class Vehicle
    {
        public Vehicle(string vehicleType)
        {
            Parts = new Dictionary<string, string>();
            VehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return Parts[key]; }
            set { Parts[key] = value; }
        }

        public string VehicleType { get; private set; }
        public Dictionary<string, string> Parts { get; private set; }
    }
}
