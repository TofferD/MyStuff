using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class AllPathsFromSourceToTargetTests
    {
        [TestMethod]
        public void PFSTValidResponseFromKnownInputTest()
        {
            int[][] testGraph = new int[][] { new int[]{ 1, 2 }, new int[] { 3 }, new int[] { 3 }, new int[] { } };

            IList<IList<int>> response = Program.AllPathsSourceTarget(testGraph);

            Assert.IsTrue(response[0][0] == 0);
            Assert.IsTrue(response[0][1] == 1);
            Assert.IsTrue(response[0][2] == 3);
            Assert.IsTrue(response[1][0] == 0);
            Assert.IsTrue(response[1][1] == 2);
            Assert.IsTrue(response[1][2] == 3);
        }
    }
}
