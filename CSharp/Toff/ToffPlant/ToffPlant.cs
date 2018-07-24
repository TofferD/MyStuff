using System;

namespace Toffsoft
{
    public abstract class ToffPlant
    {
        public ToffPlant()
        {
            GrowthRate = 1;
        }

        public int GrowthRate { get; private set; }
    }
}
