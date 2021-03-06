﻿using System;

namespace DesignPatternsStuff
{
    class Lion : Carnivore
    {
        public override string Eat(Herbivore h)
        {
            return $"{this.GetType().Name} eats {h.GetType().Name}";
        }
    }
}