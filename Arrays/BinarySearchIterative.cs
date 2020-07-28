using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class BinarySearchIterative
    {
        public static int binSearch(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            
            while(low < high)
            {
                int mid = (low + high) / 2;
                if(arr[mid] == key)
                {
                    return mid;
                }
                if(arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
        public static void Test()
        {
            int[] arr = { 1, 10, 20, 47, 59, 63, 75, 88, 99, 107, 120, 133, 155, 162, 176, 188, 199, 200, 210, 222 };
            int loc = binSearch(arr, 10);
            Console.WriteLine(loc);
        }
    }
}
