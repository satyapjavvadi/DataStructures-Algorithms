using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MergeSort
    {
        void merge(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end - start];

            int i = start, j = mid + 1, k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }

            while (j < end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            for (i = start; i < end; i++)
            {
                arr[i] = temp[i - start];
            }

            for (i = 0; i < end; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        void sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                sort(arr, start, mid);
                sort(arr, mid + 1, end);

                merge(arr, start, mid, end);
            }
        }

        static void Test(String[] args)
        {
            int[] arr = { 1, 4, 1, 6, 8, 5, 3, 7 };
            int n = arr.Length;
            Console.WriteLine("The given array is");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, n);
        }
    }
}
