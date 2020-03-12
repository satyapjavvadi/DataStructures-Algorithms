using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ReverseAnArray
    {
        static void reverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        static void Test(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int n = arr.Length;
            reverseArray(arr, 0, n - 1);
        }
    }
}
