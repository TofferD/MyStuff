using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class HammingDistanceTests
    {
        [TestMethod]
        public void HDResultFromKnownInputsTest()
        {
            Assert.IsTrue(Program.HammingDistance(1, 4) == 2);
        }

        [TestMethod]
        public void HDZeroResultFromZeroXAndYTest()
        {
            Assert.IsTrue(Program.HammingDistance(0, 0) == 0);
        }
    }
}
