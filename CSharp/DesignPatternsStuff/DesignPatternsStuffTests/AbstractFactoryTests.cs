using System;

using DesignPatternsStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsStuffTests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void AbstractFactoryTest()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            Assert.IsTrue(world.RunFoodChain() == "Lion eats Wildebeast");

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            Assert.IsTrue(world.RunFoodChain() == "Wolf eats Bison");
        }
    }
}
