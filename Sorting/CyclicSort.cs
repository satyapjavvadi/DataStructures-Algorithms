using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class CyclicSort
    {
        public static void sortArray(int[] arr)
        {
            int i = 0;
            while(i < arr.Length)
            {
                int j = arr[i] - 1;
                if(arr[i] != arr[j])
                {
                    swap(arr, i, j);
                }
                else
                {
                    i++;
                }
            }
        }
        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
        public static void Test()
        {
            int[] arr = { 3, 1, 5, 4, 2 };
            sortArray(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr = new int[] { 2, 6, 4, 3, 1, 5};
            sortArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr = new int[] { 1, 5, 6, 4, 3, 2 };
            sortArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
