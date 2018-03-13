using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class EncodeDecodeTinyUrlTests
    {
        [TestMethod]
        public void TestForEmptyOrNullUrl()
        {
            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            Assert.IsTrue(testObj.decode(testObj.encode(string.Empty)) == string.Empty);
            Assert.IsTrue(testObj.decode(testObj.encode(null)) == string.Empty);
        }
    }
}
