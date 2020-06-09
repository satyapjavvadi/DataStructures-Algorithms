using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class FirstRepeatValueinArray
    {
        public static int FindFirstRepeatValue(int[] arr)
        {
            HashSet<int> hash = new HashSet<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(hash.Contains(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    hash.Add(arr[i]);
                }
            }
            return -1;

        }
        public static void Test()
        {
            int[] arr = { 2, 3, 4, 4, 3, 5, 6 };
            Console.WriteLine(FindFirstRepeatValue(arr));
        }
    }
}
