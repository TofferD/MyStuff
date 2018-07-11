using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> Colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return Colors[key]; }
            set { Colors[key] = value; }
        }
    }
}
