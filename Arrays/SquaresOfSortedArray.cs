using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SquaresOfSortedArray
    {
        public static int[] SortedArraySquares(int[] arr)
        {
            int n = arr.Length;
            int[] sqArr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                sqArr[i] = arr[i] * arr[i];
            }

            for(int i = 0; i < sqArr.Length; i++)
            {
                for(int j = i+1; j < sqArr.Length; j++)
                {
                    if(sqArr[i] > sqArr[j])
                    {
                        int temp = sqArr[i];
                        sqArr[i] = sqArr[j];
                        sqArr[j] = temp;
                    }
                }
            }

            return sqArr;
        }
        public static void Test()
        {
            int[] arr = { -4, -1, 0, 3, 10 };
            int[] sqArr = SortedArraySquares(arr);
            Console.WriteLine(string.Join(" ", sqArr));
        }
    }
}
