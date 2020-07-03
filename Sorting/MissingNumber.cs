using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sorting
{
    class MissingNumber
    {
        public static int findMissingNumber(int[] arr)
        {
            int i = 0;
            while(i < arr.Length)
            {
                if(arr[i] < arr.Length && arr[i] != arr[arr[i]])
                {
                    swap(arr, i, arr[i]);
                }
                else
                {
                    i++;
                }
            }

            for(i = 0; i < arr.Length; i++)
            { 
                if(arr[i] != i)
                {
                    return i;
                }
            }
            return arr.Length;
        }

        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static void Test()
        {
            Console.WriteLine(findMissingNumber(new int[] { 4, 0, 3, 1 }));
            Console.WriteLine(findMissingNumber(new int[] { 8, 3, 5, 2, 4, 6, 0, 1 }));
        }
    }
}
