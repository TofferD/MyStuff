using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class MergeTwoBinaryTreesTests
    {
        [TestMethod]
        public void MTBTTreeNodeFromKnownPatternTest()
        {
            TreeNode node1 = new TreeNode(1);
            node1.Left = new TreeNode(3);
            node1.Left.Left = new TreeNode(5);
            node1.Right = new TreeNode(2);

            TreeNode node2 = new TreeNode(2);
            node2.Left = new TreeNode(1);
            node2.Left.Right = new TreeNode(4);
            node2.Right = new TreeNode(3);
            node2.Right.Right = new TreeNode(7);

            TreeNode mergedTree = TreeNode.MergeTrees(node1, node2);

            Assert.IsTrue(mergedTree.Val == 3);
            Assert.IsTrue(mergedTree.Left.Val == 4);
            Assert.IsTrue(mergedTree.Right.Val == 5);
            Assert.IsTrue(mergedTree.Right.Right.Val == 7);
            Assert.IsTrue(mergedTree.Left.Left.Val == 5);
            Assert.IsTrue(mergedTree.Left.Right.Val == 4);
        }
    }
}
