using System;
using System.Collections.Generic;
using System.Text;

namespace FastAndSlowPointer
{
    class LinkedListCycle
    {
        private static bool hasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (slow == fast)
                {
                    return true; // Found the cycle
                }
            }

            return false;
        }

        public static void Execution()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);

            Console.WriteLine("List node has cycle = " + hasCycle(head));

            head.next.next.next.next.next.next = head.next.next;

            Console.WriteLine("List node has cycle = " + hasCycle(head));

            head.next.next.next.next.next.next = head.next.next.next;

            Console.WriteLine("List node has cycle = " + hasCycle(head));

        }
    }
}
