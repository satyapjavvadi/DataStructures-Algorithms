using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class ListNode
    {
        public int value = 0;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
        }

    }
    public class LinkedListCycle
    {
        public static Boolean hasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if(slow == fast)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);
            Console.WriteLine("LinkedList has cycle: " + hasCycle(head));

            head.next.next.next.next.next.next = head.next.next;
            Console.WriteLine("LinkedList has cycle: " + hasCycle(head));

            head.next.next.next.next.next.next = head.next.next.next;
            Console.WriteLine("LinkedList has cycle: " + hasCycle(head));
        }
    }

    
}
