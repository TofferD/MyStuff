using System;

namespace DesignPatternsStuff
{
    class Wolf : Carnivore
    {
        public override string Eat(Herbivore h)
        {
            return $"{this.GetType().Name} eats {h.GetType().Name}";
        }
    }
}