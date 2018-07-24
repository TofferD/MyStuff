using System;
using System.Collections.Generic;
using System.Text;

namespace Toffsoft
{
    public class Location
    {
        public Location()
        {
            ConnectedLocations = new List<Location>();
        }

        public List<Location> ConnectedLocations { get; private set; }
    }
}
