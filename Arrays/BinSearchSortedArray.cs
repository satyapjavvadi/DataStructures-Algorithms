using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Arrays
{
    class BinSearchSortedArray
    {
        public static int binSearch(int[] arr, int key, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }
           
                int mid = (low + high) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                if (key < arr[mid])
                {
                    return binSearch(arr, key, low, mid -1);
                }
                else
                {
                    return binSearch(arr, key, mid + 1, high);
                }                
                   
            
        }
        public static void Test()
        {
            int[] arr = { 1, 10, 20, 47, 59, 63, 75, 88, 99, 107, 120, 133, 155, 162, 176, 188, 199, 200, 210, 222 };
            int key = 47;
            int loc = binSearch(arr, key, 0, arr.Length-1);
            Console.WriteLine(loc);
        }
    }
}
