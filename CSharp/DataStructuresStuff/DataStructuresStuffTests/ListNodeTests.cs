using System;

using DataStructuresStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresStuffTests
{
    [TestClass]
    public class ListNodeTests
    {
        [TestMethod]
        public void AddTwoListNodesTest()
        {
            ListNode firstNumber = new ListNode(7);
            firstNumber.Next = new ListNode(4);
            firstNumber.Next.Next = new ListNode(4);

            ListNode secondNumber = new ListNode(5);
            secondNumber.Next = new ListNode(3);
            secondNumber.Next.Next = new ListNode(6);

            ListNode answerOne = ListNode.AddTwoNumbers(firstNumber, secondNumber);
            Assert.IsTrue(answerOne.Val == 2);
            Assert.IsTrue(answerOne.Next.Val == 8);
            Assert.IsTrue(answerOne.Next.Next.Val == 0);
            Assert.IsTrue(answerOne.Next.Next.Next.Val == 1);
            Assert.IsTrue(answerOne.Next.Next.Next.Next == null);

            ListNode thirdNumber = new ListNode(1);
            thirdNumber.Next = new ListNode(2);
            thirdNumber.Next.Next = new ListNode(3);
            thirdNumber.Next.Next.Next = new ListNode(4);
            thirdNumber.Next.Next.Next.Next = new ListNode(5);

            ListNode fourthNumber = new ListNode(6);
            fourthNumber.Next = new ListNode(7);
            fourthNumber.Next.Next = new ListNode(8);
            fourthNumber.Next.Next.Next = new ListNode(9);

            ListNode answerTwo = ListNode.AddTwoNumbers(thirdNumber, fourthNumber);
            Assert.IsTrue(answerTwo.Val == 7);
            Assert.IsTrue(answerTwo.Next.Val == 9);
            Assert.IsTrue(answerTwo.Next.Next.Val == 1);
            Assert.IsTrue(answerTwo.Next.Next.Next.Val == 4);
            Assert.IsTrue(answerTwo.Next.Next.Next.Next.Val == 6);
        }

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
