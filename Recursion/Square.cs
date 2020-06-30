using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class Square
    {
        public static int findSquare(int num)
        {
            if(num == 0)
            {
                return 0;
            }
            else
            {
                return findSquare(num - 1) + (2 * num) - 1;
            }
        }
        public static void Test()
        {
            int result = findSquare(5);
            Console.WriteLine("Square of 5 is: " + result);
        }
    }
}
