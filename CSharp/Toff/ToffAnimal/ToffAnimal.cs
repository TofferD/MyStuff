using System;

namespace Toffsoft
{
    public abstract class ToffAnimal
    {
        public ToffAnimal()
        {
            Attacks = 1;
        }

        public int Attacks { get; private set; }
    }
}
