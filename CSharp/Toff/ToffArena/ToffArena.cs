using System;
using System.Collections.Generic;

namespace Toffsoft
{
    public abstract class ToffArena
    {
        public ToffArena()
        {
            Toffoids = new List<Toffoid>();
        }

        public List<Toffoid> Toffoids { get; set; }
    }
}
