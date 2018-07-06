namespace LeetCodeStuff
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x) { Val = x; }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode tempNode1 = l1 == null ? new ListNode(0) : l1;
            ListNode tempNode2 = l2 == null ? new ListNode(0) : l2;
            int addNodes = tempNode1.Val + tempNode2.Val;
            ListNode returnNode = new ListNode(addNodes % 10);
            bool remainder = addNodes >= 10;

            returnNode.Next = AddTwoNumbers(tempNode1.Next, tempNode2.Next);
            ListNode remainderNode = returnNode.Next;
            ListNode previousNode = returnNode.Next;

            while (remainder)
            {
                if (remainderNode == null)
                {
                    remainderNode = new ListNode(0);

                    if (previousNode != null)
                    {
                        previousNode.Next = remainderNode;
                    }
                    else
                    {
                        returnNode.Next = remainderNode;
                    }
                }

                remainderNode.Val = remainderNode.Val + 1;

                if (remainderNode.Val == 10)
                {
                    previousNode = remainderNode;

                    remainderNode.Val = 0;
                    remainderNode = remainderNode.Next;
                }
                else
                {
                    remainder = false;
                }
            }

            return returnNode;
        }

        public static void DeleteNode(ListNode node)
        {
            if (node.Next == null)
            {
                return;
            }

            node.Val = node.Next.Val;
            node.Next = node.Next.Next;
        }
    }
}
