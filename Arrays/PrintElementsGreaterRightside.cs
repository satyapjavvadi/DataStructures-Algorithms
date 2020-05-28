using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class PrintElementsGreaterRightside
    {
        public static void GreatestRightElement(int[] arr)
        {
            int max = int.MinValue;

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    Console.Write(arr[i]+ ",");
                }
                
            }
        }
        public static void Test()
        {
            int[] arr = { 14, 15, 8, 9, 5, 2 };
            GreatestRightElement(arr);
        }
    }
}
