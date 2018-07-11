using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStuff
{
    public class AnimalWorld
    {
        public AnimalWorld(ContinentFactory factory)
        {
            Herbivore = factory.CreateHerbivore();
            Carnivore = factory.CreateCarnivore();
        }

        private Herbivore Herbivore { get; set; }
        private Carnivore Carnivore { get; set; }

        public string RunFoodChain()
        {
            return Carnivore.Eat(Herbivore);
        }
    }
}
