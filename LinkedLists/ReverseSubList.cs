using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class ReverseSubList
    {
        public static ListNode reverse(ListNode head, int p, int q)
        {
            ListNode current = head;
            return head;
        }
        public static void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode result = reverse(head, 2, 4);
            Console.Write("Nodes of the reversed LinkedList are");
            while(result != null)
            {
                Console.Write(result.value + " ");
                result = result.next;
            }
        }
    }
}
