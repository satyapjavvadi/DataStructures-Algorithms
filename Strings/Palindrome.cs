using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class Palindrome
    {
        static bool IsPalindrome(string str)
        {
            char[] ch = str.ToCharArray();
            int first = 0, last = ch.Length - 1;

            while (first < last)
            {
                if (ch[first] == ch[last])
                {
                    first++;
                    last--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static void Test()
        {
            //int[] arr = { 5, 4, 8, 9};
            //int k = findsecondLargest(arr);
            //Console.WriteLine(k);

            string str = "madam";
            bool b = IsPalindrome(str);
            Console.WriteLine($"Palindrome is {b}");
        }
    }
}
