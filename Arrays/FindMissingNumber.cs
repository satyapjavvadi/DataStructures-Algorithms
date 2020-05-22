using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class FindMissingNumber
    {
        public static void Test()
        {
            int[] arr = { 2, 4, 1, 3, 6, 7, 8 };
            int num = MissingNumber(arr);
            Console.WriteLine(num);
        }
        //return missing element in a given array range from 1 to n
        public static int MissingNumber(int[] arr)
        {
            int n = arr.Length + 1;
            int sum = (n * (n + 1)) / 2;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum - arr[i];
            }
            return sum;

        }
    }
}
