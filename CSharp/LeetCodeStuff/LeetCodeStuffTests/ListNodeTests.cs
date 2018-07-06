using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeetCodeStuff;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class ListNodeTests
    {
        [TestMethod]
        public void LinkedListNodesAddAtIndexTest()
        {
            LinkedListNodes linkedListNodes = new LinkedListNodes();

            linkedListNodes.AddAtHead(1);
            linkedListNodes.AddAtTail(3);
            linkedListNodes.AddAtIndex(1, 2);
            Assert.IsTrue(linkedListNodes.Get(1) == 2);
            linkedListNodes.DeleteAtIndex(1);
            Assert.IsTrue(linkedListNodes.Get(1) == 3);
        }

        [TestMethod]
        public void LinkedListNodesGetTest()
        {
            LinkedListNodes linkedListNodes = new LinkedListNodes();

            linkedListNodes.AddAtHead(1);
            linkedListNodes.AddAtIndex(1, 2);
            Assert.IsTrue(linkedListNodes.Get(1) == 2);
            Assert.IsTrue(linkedListNodes.Get(0) == 1);
            Assert.IsTrue(linkedListNodes.Get(5) == -1);
        }

        [TestMethod]
        public void LinkedListNodesPerfTest()
        {
            LinkedListNodes linkedListNodes = new LinkedListNodes();

            Assert.IsTrue(linkedListNodes.Get(0) == -1);
            linkedListNodes.AddAtIndex(1, 2);
            Assert.IsTrue(linkedListNodes.Get(0) == -1);
            Assert.IsTrue(linkedListNodes.Get(1) == -1);
            linkedListNodes.AddAtIndex(0, 1);
            Assert.IsTrue(linkedListNodes.Get(0) == 1);
            Assert.IsTrue(linkedListNodes.Get(1) == -1);
        }

        [TestMethod]
        public void HasCycleTest()
        {
            Assert.IsFalse(ListNode.HasCycle(null));
            Assert.IsFalse(ListNode.HasCycle(new ListNode(1)));
        }
    }
}
