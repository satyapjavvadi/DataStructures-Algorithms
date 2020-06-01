using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MaxSumSubArray
    {
        public static int findMaxSumSubArray(int[] arr, int k)
        {
            int max_sum = 0;

            for(int i = 0; i < arr.Length-k; i++)
            {
                int sum = 0;
                for(int j = i; j < i+k; j++)
                {
                    sum = sum + arr[j];
                    if(sum > max_sum)
                    {
                        max_sum = sum; 
                    }
                    
                }
            }
            return max_sum;

        }
        public static void Test()
        {
            int[] arr = { 2, 1, 5, 1, 3, 2 };
            int res = findMaxSumSubArray(arr, 3);
            Console.WriteLine(res);
        }
    }
}
