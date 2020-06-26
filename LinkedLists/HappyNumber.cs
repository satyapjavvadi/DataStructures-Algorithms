using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LinkedLists
{
    class HappyNumber
    {
        public static Boolean find(int num)
        {
            int slow = num;
            int fast = num;

            do
            {
                slow = findSquareNum(slow);
                fast = findSquareNum(findSquareNum(fast));
            } while (slow != fast);

            return slow == 1;

        }

        public static int findSquareNum(int num)
        {
            int sum = 0, digit;

            while(num > 0)
            {
                digit = num % 10;
                sum = sum + digit * digit;
                num = num / 10;
            }
             return sum;
        }

        public static void Test()
        {
            Console.WriteLine(find(23));
            Console.WriteLine(find(12));
        }
    }
}
