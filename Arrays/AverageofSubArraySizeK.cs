using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    // A brute-force approach
   /* class AverageofSubArraySizeK
    {
        public static double[] findAverages(int[] arr, int k)
        {
            double[] res = new double[arr.Length - k + 1];

            for(int i = 0; i <= arr.Length-k; i++)
            {
                // finding sum of next 'k' elements
                double sum = 0;
                for(int j = i; j < i+k; j++)
                {
                    sum = sum + arr[j];
                    res[i] = sum / k; //calculating average
                }
            }
            return res;
        }
        public static void Test()
        {
            int[] arr = { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            double[] result = findAverages(arr, 5);
            Console.WriteLine(String.Join(", " ,result));
        }
    } */

    // sliding window approach
    class AverageofSubArraySizeK
    {
        public static double[] findAverages(int[] arr, int k)
        {
            double[] res = new double[arr.Length - k + 1];
            double winSum = 0;
            int winStart = 0;

            for(int winEnd = 0; winEnd < arr.Length; winEnd++)
            {
                winSum = winSum + arr[winEnd];

                if(winEnd >= k-1)
                {
                    res[winStart] = winSum / k;
                    winSum = winSum - arr[winStart];
                    winStart++;
                }
            }
            return res;
        }
        public static void Test()
        {
            int[] arr = { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            double[] result = findAverages(arr, 5);
            Console.WriteLine(string.Join(" ,", result));
        }
    }
}
