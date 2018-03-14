using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class EncodeDecodeTinyUrlTests
    {
        [TestMethod]
        public void EDTEncodeEmptyOrNullUrlReturnsEmptyStringTest()
        {
            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            Assert.IsTrue(testObj.encode(string.Empty) == string.Empty);
            Assert.IsTrue(testObj.encode(null) == string.Empty);
        }

        [TestMethod]
        public void EDTDecodeEmptyOrNullUrlReturnsEmptyStringTest()
        {
            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            Assert.IsTrue(testObj.decode(string.Empty) == string.Empty);
            Assert.IsTrue(testObj.decode(null) == string.Empty);
        }

        [TestMethod]
        public void EDTUrlIsShorterOrEqualThanTinyReturnsOriginalUrlTest()
        {
            string littleUrl = "a";
            string mediumUrl = "bbbbbbbbbbbbbbbbbbbbbbbbbbb";

            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            string littleResponse = testObj.encode(littleUrl);
            string mediumResponse = testObj.encode(mediumUrl);

            Assert.IsTrue(littleResponse == littleUrl);
            Assert.IsTrue(mediumResponse == mediumUrl);
        }

        [TestMethod]
        public void EDTUrlIsLongerThanTinyReturnsTinyUrlTest()
        {
            string bigUrl = "cccccccccccccccccccccccccccc";
            string superBigUrl = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            string bigResponse = testObj.encode(bigUrl);
            string superBigResponse = testObj.encode(superBigUrl);

            Assert.IsTrue(bigResponse != bigUrl);
            Assert.IsTrue(superBigResponse != superBigUrl);
        }

        [TestMethod]
        public void EDTDecodedTinyReturnsOriginalUrlTest()
        {
            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            string superBigUrl = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            string superBigResponse = testObj.decode(testObj.encode(superBigUrl));

            Assert.IsTrue(superBigResponse == superBigUrl);
        }

        [TestMethod]
        public void EDTDecodedInvalidTinyReturnsEmptyStringTest()
        {
            EncodeDecodeTinyUrl testObj = new EncodeDecodeTinyUrl();

            string superBigResponse = testObj.decode("somecrazykeythatdoesnotexist");

            Assert.IsTrue(superBigResponse == string.Empty);
        }
    }
}
