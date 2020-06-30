using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class Factorial
    {
        public static int factorial(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            else
            {
                return (num * factorial(num - 1));
            }
        }
        public static void Test()
        {
            int result = factorial(5);
            Console.WriteLine("Factorial of 5 is: " + result);
        }
    }
}
