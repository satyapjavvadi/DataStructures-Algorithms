using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class EquilibriumIndex
    {
        public static int getEquilibriumIndex(int[] arr)
        {
            int sum = 0;
            int sum_so_far = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum - arr[i];
                if(sum == sum_so_far)
                {
                    return i;
                }
                sum_so_far = sum_so_far + arr[i];
            }
            return -1;
        }
        public static void Test()
        {
            int[] arr = { 1, 6, 7, 0, 7 };
            int b = getEquilibriumIndex(arr);
            Console.WriteLine(b);
        }
    }
}
