﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Arrays
{
    /*
    //Target sum using two pointers approach
    class PairWithTargetSum
    {
        public static int[] SearchTheSum(int[] arr, int targetSum)
        {
            int left = 0, right = arr.Length - 1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[left] + arr[right] == targetSum)
                {
                    return new int[] { left, right };
                }
                else if(arr[left] + arr[right] > targetSum)
                {
                    right--;
                }
                else if(arr[left] + arr[right] < targetSum)
                {
                    left++;
                }
            }
            return new int[] { -1, -1 };
        }
        public static void Test()
        {
            int[] result = SearchTheSum(new int[] { 1, 2, 3, 4, 6 }, 6);
            Console.WriteLine($"Pair with target sum {result[0]} , {result[1]}");
            result = SearchTheSum(new int[] { 2, 5, 9, 11 }, 11);
            Console.WriteLine($"Pair with target sum {result[0]} , {result[1]}");

        }
    }
    */

    //Target sum using dictionary

    class PairWithTargetSum
    {
        public static int[] SearchTheSum(int[] arr, int targetSum)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if(dict.ContainsKey(targetSum - arr[i]))
                {
                    return new int[] { dict.GetValueOrDefault(targetSum - arr[i]), i };
                }
                else
                {
                    dict.Add(arr[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
        public static void Test()
        {
            int[] result = SearchTheSum(new int[] { 1, 2, 3, 4, 6 }, 6);
            Console.WriteLine($"Pair with target sum {result[0]} , {result[1]}");
            result = SearchTheSum(new int[] { 2, 5, 9, 11 }, 11);
            Console.WriteLine($"Pair with target sum {result[0]} , {result[1]}");
        }
    }

}
