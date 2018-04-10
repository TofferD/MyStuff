using LeetCodeStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStuffTests
{
    [TestClass]
    public class MaxBinaryTreeTests
    {
        [TestMethod]
        public void MBTEmptyArrayReturnsNullResultTest()
        {
            TreeNode result = TreeNode.ConstructMaximumBinaryTree(new int[] { });

            Assert.IsNull(result);
        }

        [TestMethod]
        public void MBTNullArrayReturnsNullResultTest()
        {
            TreeNode result = TreeNode.ConstructMaximumBinaryTree(null);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void MBTTreeNodeFromKnownPatternTest()
        {
            TreeNode result = TreeNode.ConstructMaximumBinaryTree(new int[]{ 3, 2, 1, 6, 0, 5 });

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Val == 6);
            Assert.IsNotNull(result.Left);
            Assert.IsTrue(result.Left.Val == 3);
            Assert.IsNotNull(result.Right);
            Assert.IsTrue(result.Right.Val == 5);
            Assert.IsNotNull(result.Left.Right);
            Assert.IsTrue(result.Left.Right.Val == 2);
            Assert.IsNotNull(result.Right.Left);
            Assert.IsTrue(result.Right.Left.Val == 0);
            Assert.IsNotNull(result.Left.Right.Right);
            Assert.IsTrue(result.Left.Right.Right.Val == 1);
        }
    }
}