using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class LargestContiguousSum
    {
        public static int ContiguousSum(int[] arr)
        {
            int cur_sum = arr[0];
            int max_so_far = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                cur_sum = cur_sum + arr[i];
                if (cur_sum < arr[i])
                {
                    cur_sum = arr[i];
                }

                if( max_so_far < cur_sum)
                {
                    max_so_far = cur_sum;
                }
            }
            return max_so_far;
        }

        public static void Test()
        {
            int[] arr = { -3, -4, 4, -1, -2, 1, 5, -3 };
            int b = ContiguousSum(arr);
            Console.WriteLine(b);
        }
    }
}
