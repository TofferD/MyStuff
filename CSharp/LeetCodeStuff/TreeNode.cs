using System;

namespace LeetCodeStuff
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int x) { Val = x; }

        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return null;
            }

            int highestIndex = 0;
            int highest = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                    highestIndex = i;
                }
            }

            TreeNode returnNode = new TreeNode(highest);
            int[] leftArray = new int[highestIndex];
            int[] rightArray = new int[nums.Length - highestIndex - 1];
            Array.Copy(nums, 0, leftArray, 0, highestIndex);
            Array.Copy(nums, highestIndex + 1, rightArray, 0, nums.Length - highestIndex - 1);
            returnNode.Left = ConstructMaximumBinaryTree(leftArray);
            returnNode.Right = ConstructMaximumBinaryTree(rightArray);

            return returnNode;
        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return null;
            }

            TreeNode temp1 = t1 == null ? new TreeNode(0) : t1;
            TreeNode temp2 = t2 == null ? new TreeNode(0) : t2;
            TreeNode mergedNode = new TreeNode(temp1.Val + temp2.Val);
            mergedNode.Left = MergeTrees(temp1.Left, temp2.Left);
            mergedNode.Right = MergeTrees(temp1.Right, temp2.Right);

            return mergedNode;
        }
    }
}
