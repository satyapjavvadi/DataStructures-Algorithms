using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SearchValueDifferenceisK
    {
        public static int findAdjacentValue(int[] arr, int k, int val)
        {
            int start = 0;
            while(start < arr.Length)
            {
                if(arr[start] == val)
                {
                    return start;
                }

                int diff = Math.Abs(arr[start] - val) / k;
                diff = Math.Max(1, diff);
                start = start + diff;

            }
            return -1;
        }
        public static void Test()
        {
            int[] arr = { 70, 60, 70, 80, 90, 110, 130 };
            int index = findAdjacentValue(arr, 20, 110);
            Console.WriteLine(index);
            
        }
    }
}
