using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeetCodeStuff;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class HashSetTests
    {
        [TestMethod]
        public void HashSetBasicTest()
        {
            HashSet hashSet = new HashSet();
            hashSet.Add(1);
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(1));
            Assert.IsFalse(hashSet.Contains(3));
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(2));
            hashSet.Remove(2);
            Assert.IsFalse(hashSet.Contains(2));
        }
    }    
}