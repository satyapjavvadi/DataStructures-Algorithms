using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class PrintFirst20Integers
    {
        static int n = 0;
        public static void indirectRecursionFunction1()
        {
            if(n <= 20)
            {
                Console.Write(n + " ");
                n++;
                indirectRecursionFunction2();
            }
            else
            {
                return;
            }

        }
        public static void indirectRecursionFunction2()
        {
            if(n <= 20)
            {
                Console.Write(n + " ");
                n++;
                indirectRecursionFunction1();
            }
            else
            {
                return;
            }
        }
        public static void Test()
        {
            indirectRecursionFunction1();
        }
    }
}
