using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class ReverseLinkedList
    {
        public static ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while(current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
        public static void Test()
        {
            ListNode head = new ListNode(2);
            head.next = new ListNode(4);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(8);
            head.next.next.next.next = new ListNode(10);

            ListNode result = reverse(head);
            Console.Write("Nodes of the LinkedList are:");
            while(result != null)
            {
                Console.Write(result.value + " ");
                result = result.next;
            }
        }
    }
}
