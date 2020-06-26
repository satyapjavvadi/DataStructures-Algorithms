using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class MiddleoftheLinkedList
    {
        public static ListNode findMiddle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        public static void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            Console.WriteLine("Middle Node: " + findMiddle(head).value);

            head.next.next.next.next.next = new ListNode(6);
            Console.WriteLine("Middle Node: " + findMiddle(head).value);

            head.next.next.next.next.next.next = new ListNode(7);
            Console.WriteLine("Middle Node: " + findMiddle(head).value);

        }
    }
}
