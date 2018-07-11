using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public class Color : ColorPrototype
    {
        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Blue = blue;
            this.Green = green;
        }

        public int Red { get; private set; }
        public int Green { get; private set; }
        public int Blue { get; private set; }

        public override ColorPrototype Clone()
        {
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
