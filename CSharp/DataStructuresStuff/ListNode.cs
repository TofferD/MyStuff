namespace DataStructuresStuff
{
    public class ListNode
    {
        public ListNode(int x) { Val = x; }

        public ListNode Next;

        public int Val;

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode tempNode1 = (l1 == null ? new ListNode(0) : l1);
            ListNode tempNode2 = (l2 == null ? new ListNode(0) : l2);

            int addNodes = tempNode1.Val + tempNode2.Val;

            ListNode returnNode = new ListNode(addNodes % 10);
            bool remainder = addNodes >= 10;

            returnNode.Next = AddTwoNumbers(tempNode1.Next, tempNode2.Next);
            ListNode remainderNode = returnNode.Next;

            while (remainder)
            {
                if (remainderNode == null)
                {
                    remainderNode = new ListNode(0);
                    returnNode.Next = remainderNode;
                }

                remainderNode.Val = remainderNode.Val + 1;

                if (remainderNode.Val != 10)
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

        public static bool HasCycle (ListNode head)
        {
            ListNode slowRunner = head;
            ListNode fastRunner = head;

            do
            {
                if (slowRunner == null || fastRunner == null)
                {
                    return false;
                }

                slowRunner = slowRunner.Next;

                if (fastRunner.Next != null)
                {
                    fastRunner = fastRunner.Next.Next;
                }
                else
                {
                    fastRunner = null;
                }
            }
            while (fastRunner != slowRunner);

            return true;
        }
    }

    public class LinkedListNodes
    {
        public LinkedListNodes() { }

        public ListNode HeadListNode { get; set; }

        public void AddAtHead(int val)
        {
            ListNode current = new ListNode(val);
            current.Next = HeadListNode;
            HeadListNode = current;
        }

        public void AddAtIndex(int index, int val)
        {
            if (HeadListNode == null && index > 0)
            {
                return;
            }

            ListNode current = HeadListNode;
            ListNode previous = HeadListNode;
            int nodeCount = 0;

            for (; nodeCount < index;)
            {
                if (current != null)
                {
                    previous = current;
                    current = current.Next;
                    nodeCount++;
                }
            }

            if (nodeCount == index)
            {
                ListNode newNode = new ListNode(val);

                if(previous != null)
                {
                    previous.Next = newNode;
                }
                else
                {
                    HeadListNode = newNode;
                }

                newNode.Next = current;
            }
        }

        public void AddAtTail(int val)
        {
            ListNode newNode = new ListNode(val);

            ListNode current = HeadListNode;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void DeleteAtIndex(int index)
        {
            ListNode current = HeadListNode;
            ListNode previous = HeadListNode;

            for (int i = 0; i < index; ++i)
            {
                previous = current;
                current = current.Next;
            }

            if (current != null)
            {
                previous.Next = current.Next;
            }
        }

        public int Get(int index)
        {
            ListNode current = HeadListNode;

            for(int i = 0; i < index; ++i)
            {
                if (current != null)
                {
                    current = current.Next;
                }
            }

            if (current != null)
            {
                return current.Val;
            }

            return -1;
        }
    }
}
