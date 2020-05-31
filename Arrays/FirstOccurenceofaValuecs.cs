using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class FirstOccurenceofaValuecs
    {
        public static void Test()
        {
            int[] arr = { 2, 3, 2, 4, 5, 6, 7 };
            int a = FirstOcuurenceValue(arr, 2);
            Console.WriteLine(a);
        }
        public static int FirstOcuurenceValue(int[] arr, int val)
        {
            if(arr.Length == 0)
            {
                return -1;
            }

            int start = 0;

            while(start < arr.Length)
            {
                if(arr[start] == val)
                {
                    return start;
                }

                int diff = Math.Abs(arr[start] - val);
                start = start + diff;
            }

            return -1;
        }
    }
}
