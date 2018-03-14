using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeStuff
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Program
    {
        public static void Main(string[] args) {}

        public static int JewelsAndStones(string jewels, string stones)
        {
            if (string.IsNullOrEmpty(jewels) || string.IsNullOrEmpty(stones))
            {
                return 0;
            }

            int jewelCount = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                {
                    jewelCount++;
                }
            }

            return jewelCount;
        }

        public static void SwapPairs(ref ListNode node)
        {
            if (node == null || node.next == null)
            {
                return;
            }

            ListNode node1 = node; // Node 1 -> A 
            ListNode node2 = node.next; // node 2 -> B
            ListNode node3 = node.next.next; // Node 3 -> C

            node = node2; //Node-> B
            node.next = node1; // B->A
            node.next.next = node3;// B->A->C->D

            SwapPairs(ref node.next.next);
        }


    //    // Input A->B->C->D
    //    // Output B->A->D->C
    //    /*
    //    * public class ListNode {
    //     *     public int val;
    //     *     public ListNode next;
    //     *     public ListNode(int x) { val = x; }
    //     * }

    //    */

    //    public void SwapPairs(ListNode node, out ListNode newHead)
    //    {
    //        if (node == null || node.next == null)
    //        {
    //            return;
    //        }

    //        ListNode node1 = node; // Node 1 -> A 
    //        ListNode node2 = node.next; // node 2 -> B
    //        ListNode node3 = node.next.next; // Node 3 -> C
    
    //out newHead = node2; //Node-> B
    //        node.next = node1 // B->A
    //node.next.next = node3;// B->A->C->D

    //        SwapPairs(node.next.next);
    //    }

        public static void DeleteNode(ListNode node)
        {
            if (node.next == null)
            {
                return;
            }

            node.val = node.next.val;
            node.next = node.next.next;
        }

        public static string ReverseString(string s)
        {
            if (s == null || s.Length == 0)
            {
                return string.Empty;
            }

            char[] reversed = new char[s.Length];

            for (int i = 0; i < s.Length; ++i)
            {
                reversed[(s.Length - (i + 1))] = s[i];
            }

            return new string(reversed);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int lastNum = nums[0];
            int nextIndex = 1;

            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] != lastNum)
                {
                    lastNum = nums[i];
                    nums[nextIndex++] = nums[i];
                }
            }

            return nextIndex;
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode tempNode1 = l1 == null ? new ListNode(0) : l1;
            ListNode tempNode2 = l2 == null ? new ListNode(0) : l2;
            int addNodes = tempNode1.val + tempNode2.val;
            ListNode returnNode = new ListNode(addNodes % 10);
            bool remainder = addNodes >= 10;

            returnNode.next = AddTwoNumbers(tempNode1.next, tempNode2.next);
            ListNode remainderNode = returnNode.next;
            ListNode previousNode = returnNode.next;

            while (remainder)
            {
                if (remainderNode == null)
                {
                    remainderNode = new ListNode(0);

                    if (previousNode != null)
                    {
                        previousNode.next = remainderNode;
                    }
                    else
                    {
                        returnNode.next = remainderNode;
                    }
                }

                remainderNode.val = remainderNode.val + 1;

                if (remainderNode.val == 10)
                {
                    previousNode = remainderNode;

                    remainderNode.val = 0;
                    remainderNode = remainderNode.next;
                }
                else
                {
                    remainder = false;
                }
            }

            return returnNode;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            int[] array = new int[5];


            int longestCount = 0;
            int start = 0;
            int end = 1;

            if (s.Length <= 1)
            {
                return s.Length;
            }

            if (s.Length == 2 && s[0] != s[1])
            {
                return 2;
            }

            while ((end - start) < (s.Length - start))
            {
                if (s.Substring(start, (end - start)).Contains(s[end]))
                {
                    int count = end - start;

                    if (count > longestCount)
                    {
                        longestCount = count;
                    }

                    start = end;
                }

                end = end + 1;
            }

            return longestCount;
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> selfDividingNumbers = new List<int>();

            if (left < 1 || right < 1 || left > 10000 || right > 10000)
            {
                return selfDividingNumbers;
            }

            if (right < left)
            {
                return SelfDividingNumbers(right, left);
            }

            for (int i = left; i <= right; i++)
            {
                string s = i.ToString();
                bool isSelfDividing = true;

                for (int j = 0; j < s.Length; j++)
                {
                    int digit = Convert.ToInt32(s[j].ToString());

                    if ((s[j] == '0') || (i % digit != 0))
                    {
                        isSelfDividing = false;
                        break;
                    }
                }

                if (isSelfDividing)
                {
                    selfDividingNumbers.Add(i);
                }
            }

            return selfDividingNumbers;
        }

        public static int ArrayPairSum(int[] nums)
        {
            if (nums.Length < 2 || nums.Length > 20000)
            {
                return 0;
            }

            SortedDictionary<int, int> sortedNums = new SortedDictionary<int, int>();
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (sortedNums.Keys.Contains(nums[i]))
                {
                    sortedNums[nums[i]]++;
                }
                else
                {
                    sortedNums.Add(nums[i], 1);
                }
            }

            int p1 = -1;
            int p2 = -1;

            foreach (int key in sortedNums.Keys)
            {
                int numOfKey = sortedNums[key];

                while (numOfKey >= 0)
                {
                    if (p1 == -1 && numOfKey > 0)
                    {
                        p1 = key;
                        numOfKey -= 1;

                        if (numOfKey >= 0)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (p2 == -1 && numOfKey > 0)
                    {
                        p2 = key;
                        numOfKey -= 1;

                        if (numOfKey >= 0)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (p1 != -1 && p2 != -1)
                    {
                        total += p1 < p2 ? p1 : p2;
                        p1 = -1;
                        p2 = -1;
                    }
                    else if ((p1 == -1 || p2 == -1) && numOfKey == 0)
                    {
                        break;
                    }
                }
            }

            return total;
        }
    }
}
