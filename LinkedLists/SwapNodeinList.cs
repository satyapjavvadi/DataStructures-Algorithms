using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class SwapNodeinList
    {
        public static ListNode swapNodes(ListNode head)
        {
            ListNode temp = null;
            temp.next = head;

          
            while(temp != null && temp.next != null)
            {
                ListNode k = temp;
                temp = temp.next;
                temp.next = k;
                k = temp.next.next;
            }
            return head;
        }
        public static void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            swapNodes(head);

            while (head != null)
            {
                Console.Write(head.value + " ");
                head = head.next;
            }
        }
    }
}
