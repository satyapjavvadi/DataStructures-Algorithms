using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SearchValueinArray
    {
        public static void Test()
        {
            // Search value in an unsorted array
            int[] arr = { 14, 15, 8, 9, 5, 2 };
            int b = SearchArray(arr, 9);
            Console.WriteLine("The value is at index in an unsorted array " + b);

            // Search value in a sorted array

            int[] a = { 2, 5, 7, 8, 10, 11 };
            int c = SearchSortedArray(a, 10);
            Console.WriteLine("The value is at index in a sorted array " + c);

        }
        public static int SearchArray(int[] arr, int val)
        {
            if(arr.Length == 0)
            {
                return -1;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int SearchSortedArray(int[] a, int v)
        {
            int start = 0;
            int end = a.Length - 1;
            int mid = 0;

            while(start <= end)
            {
                mid = (start + end) / 2;
                if(a[mid] == v)
                {
                    return mid;
                }
                else if(a[mid] < v)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}