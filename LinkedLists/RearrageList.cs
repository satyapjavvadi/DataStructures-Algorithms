using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace LinkedLists
{
    class RearrageList
    {
        public static void reorder(ListNode head)
        {
            if (head == null || head.next == null)
                return;

            //find the middle of the linkedlist
            ListNode slow = head;
            ListNode fast = head;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //slow is now pointin to the middle node now
            ListNode headSecondHalf = reverse(slow);  //reverse the second half
            ListNode headFirstHalf = head;

            //rearrage to produce the LinkedList in the required order
            while(headFirstHalf != null && headSecondHalf != null)
            {
                ListNode temp = headFirstHalf.next;
                headFirstHalf.next = headSecondHalf;
                headFirstHalf = temp;

                temp = headSecondHalf.next;
                headSecondHalf.next = headFirstHalf;
                headSecondHalf = temp;
            }

            //set the next of the last node to null

            if(headFirstHalf != null)
            {
                headFirstHalf.next = null;
            }
        }

        public static ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            while(head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
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
            head.next.next.next.next.next = new ListNode(12);
            reorder(head);
            while(head != null)
            {
                Console.Write(head.value + " ");
                head = head.next;
            }
        }
    }
}
