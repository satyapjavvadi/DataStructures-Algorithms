using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Arrays
{
    
    class MaxSumSubArray
    {
        // brute-force approach
       /* public static int findMaxSumSubArray(int[] arr, int k)
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

        } */

        // sliding window approach

        public static int findMaxSumSubArray(int[] arr, int S)
        {
            int winStart = 0, winSum = 0;
            int minLength = int.MaxValue;

            for(int winEnd = 0; winEnd < arr.Length; winEnd++)
            {
                winSum = winSum + arr[winEnd];
                while(winSum >= S)
                {
                    minLength = Math.Min(minLength, winEnd - winStart + 1);
                    winSum = winSum - arr[winStart];
                    winStart++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
            
        }
        public static void Test()
        {
            int[] arr = { 2, 1, 5, 2, 3, 2 };
            int S = 7; 
            int res = findMaxSumSubArray(arr, S);
            Console.WriteLine(res);
        }
    }
}
