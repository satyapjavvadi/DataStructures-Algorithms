using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    // A brute-force approach
    class AverageofSubArraySizeK
    {
        public static double[] findAverages(int[] arr, int k)
        {
            double[] res = new double[arr.Length - k + 1];

            for(int i = 0; i <= arr.Length-k; i++)
            {
                double sum = 0;
                for(int j = i; j < i+k; j++)
                {
                    sum = sum + arr[j];
                    res[i] = sum / k;
                }
            }
            return res;
        }
        public static void Test()
        {
            int[] arr = { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            double[] result = findAverages(arr, 5);
            Console.WriteLine(String.Join(" " ,result));
        }
    }
}
