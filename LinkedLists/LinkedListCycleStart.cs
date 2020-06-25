using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LinkedLists
{
    class LinkedListCycleStart
    {
        public static ListNode findCycleStart(ListNode head)
        {
            int cycleLength = 0;
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if(slow == fast)
                {
                    cycleLength = calculateCycleLength(slow);
                    break;
                }
            }
            return findStart(head, cycleLength);
        }

        public static int calculateCycleLength(ListNode slow)
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

        public static ListNode findStart(ListNode head, int cycleLength)
        {
            ListNode pointer1 = head;
            ListNode pointer2 = head;

            while(cycleLength > 0)
            {
                pointer2 = pointer2.next;
                cycleLength--;
            }

            while (pointer1 != pointer2)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
            }
            return pointer1;
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
            Console.WriteLine("LinkedList cycle start: " + findCycleStart(head).value);
        }
    }
}
