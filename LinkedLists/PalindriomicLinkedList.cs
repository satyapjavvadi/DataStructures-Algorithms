using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LinkedLists
{
    class PalindriomicLinkedList
    {
        public static Boolean isPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode headSecondHalf = reverse(slow); //reverse the second half
            ListNode copyHeadSecondHalf = headSecondHalf; //strore the head of reversed part to revert back later

            //compare the first half and the second half
            while(head != null && headSecondHalf != null)
            {
                if(head.value != headSecondHalf.value)
                {
                    break; // not a palindrome
                }

                head = head.next;
                headSecondHalf = headSecondHalf.next;
            }

            reverse(copyHeadSecondHalf); //revert the reverse of the second half

            if (head == null || headSecondHalf == null) //if both halves match
                return true;
            return false;
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
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(2);
            Console.WriteLine("Is Palindrome: " + isPalindrome(head));

            head.next.next.next.next.next = new ListNode(2);
            Console.WriteLine("Is Palindrome: " + isPalindrome(head));
        }
    }
}
