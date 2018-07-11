using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            Vehicle = new Vehicle("Motorcycle");
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Motorcycle Frame";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }
    }
}
