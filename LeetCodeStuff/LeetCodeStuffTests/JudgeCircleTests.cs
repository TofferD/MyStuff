using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class JudgeCircleTests
    {
        [TestMethod]
        public void JCCompleteCircleInTwoStepsUpDownTest()
        {
            Assert.IsTrue(Program.JudgeCircle("UD"));
            Assert.IsTrue(Program.JudgeCircle("DU"));
        }

        [TestMethod]
        public void JCCompleteCircleInTwoStepsRightLeftTest()
        {
            Assert.IsTrue(Program.JudgeCircle("RL"));
            Assert.IsTrue(Program.JudgeCircle("LR"));
        }

        [TestMethod]
        public void JCCompleteCircleUsingAllDirectionsTest()
        {
            Assert.IsTrue(Program.JudgeCircle("URDL"));
            Assert.IsTrue(Program.JudgeCircle("LDRU"));
            Assert.IsTrue(Program.JudgeCircle("UDLR"));
            Assert.IsTrue(Program.JudgeCircle("RDUL"));
        }

        [TestMethod]
        public void JCMovesNotEqualToCircleTest()
        {
            Assert.IsFalse(Program.JudgeCircle("URRDDDLLLL"));
        }

        [TestMethod]
        public void JCInvalidCharactersDoesNotMoveTest()
        {
            Assert.IsTrue(Program.JudgeCircle("ABCEFGHIJKMNOPQSTVWXYZ"));
        }

        [TestMethod]
        public void JCEmptyOrNullStringDoesNotMoveTest()
        {
            Assert.IsTrue(Program.JudgeCircle(string.Empty));
            Assert.IsTrue(Program.JudgeCircle(null));
        }
    }
}
