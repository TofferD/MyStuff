using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeStuff
{
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

        public static int HammingDistance(int x, int y)
        {
            int z = x ^ y;
            int count = 0;

            while (z != 0)
            {
                count++;
                z &= (z - 1);
            }

            return count;
        }

        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            List<List<int>> returnList = new List<List<int>>();

            return (IList<IList<int>>)returnList;
        }

        public static bool JudgeCircle(string moves)
        {
            if (string.IsNullOrEmpty(moves))
            {
                return true;
            }

            string loweredMoves = moves.ToLower();

            int lr = 0;
            int ud = 0;

            for (int i = 0; i < loweredMoves.Length; i++)
            {
                switch (loweredMoves[i])
                {
                    case 'u':
                        {
                            ud++;
                            break;
                        }
                    case 'd':
                        {
                            ud--;
                            break;
                        }
                    case 'r':
                        {
                            lr++;
                            break;
                        }
                    case 'l':
                        {
                            lr--;
                            break;
                        }
                }
            }

            return (lr == 0) && (ud == 0);
        }

        public static void SwapPairs(ref ListNode node)
        {
            if (node == null || node.Next == null)
            {
                return;
            }

            ListNode node1 = node; // Node 1 -> A 
            ListNode node2 = node.Next; // node 2 -> B
            ListNode node3 = node.Next.Next; // Node 3 -> C

            node = node2; //Node-> B
            node.Next = node1; // B->A
            node.Next.Next = node3;// B->A->C->D

            SwapPairs(ref node.Next.Next);
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
