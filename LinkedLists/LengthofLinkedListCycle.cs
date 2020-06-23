using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class LengthofLinkedListCycle
    {
        public static int findCycleLength(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (slow == fast)
                {
                    return calculateLength(slow);
                }
            }
                return 0;

        }

        public static int calculateLength(ListNode slow)
        {
            ListNode current = slow;
            int cycleLength = 0;

            do
            {
                current = current.next;
                cycleLength++;
            } while (current != slow);

            return cycleLength;
        }

        public static void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);

            head.next.next.next.next.next.next = head.next.next;
            Console.WriteLine("LinkedList cycle Length: " + findCycleLength(head));

            head.next.next.next.next.next.next = head.next.next.next;
            Console.WriteLine("LinkedList cycle Length: " + findCycleLength(head));
        }

    }
}
