﻿using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class JewelsAndStonesTests
    {
        [TestMethod]
        public void JASNullOrEmptyJewelsIsZeroTest()
        {
            Assert.IsTrue(Program.JewelsAndStones(string.Empty, "a") == 0);
            Assert.IsTrue(Program.JewelsAndStones(null, "a") == 0);
        }

        [TestMethod]
        public void JASNullOrEmptyStonesIsZeroTest()
        {
            Assert.IsTrue(Program.JewelsAndStones("a", string.Empty) == 0);
            Assert.IsTrue(Program.JewelsAndStones("a", null) == 0);
        }

        [TestMethod]
        public void JASSingleJewelFoundInStonesTest()
        {
            Assert.IsTrue(Program.JewelsAndStones("a", "abbbb") == 1);
            Assert.IsTrue(Program.JewelsAndStones("z", "yyyyz") == 1);
            Assert.IsTrue(Program.JewelsAndStones("m", "nnmnn") == 1);
        }

        [TestMethod]
        public void JASMultipleJewelFoundInStonesTest()
        {
            Assert.IsTrue(Program.JewelsAndStones("a", "aabbb") == 2);
            Assert.IsTrue(Program.JewelsAndStones("z", "yyyzz") == 2);
            Assert.IsTrue(Program.JewelsAndStones("m", "nmmnn") == 2);
            Assert.IsTrue(Program.JewelsAndStones("t", "ststs") == 2);
        }
    }
}
