using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class CheckPairwithSum
    {
        public static bool IsPairExistsWithSum(int[] arr, int val)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == val)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void Test()
        {
            int[] arr = { 12, 3, 5, 1, 9 };
            bool b = IsPairExistsWithSum(arr, 10);
            Console.WriteLine(b);
        }
    }
}
