using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SortedArraySquares
    {
        public static int[] makeSquares(int[] arr)
        {
            int n = arr.Length;
            int[] squares = new int[n];
            int highestSquareIndex = n - 1;
            int left = 0, right = n - 1;
            while(left <= right)
            {
                int leftSquare = arr[left] * arr[left];
                int rightSquare = arr[right] * arr[right];

                if(leftSquare > rightSquare)
                {
                    squares[highestSquareIndex--] = leftSquare;
                    left++;
                }
                else
                {
                    squares[highestSquareIndex--] = rightSquare;
                    right--;
                }
            }
            return squares;

        }
        public static void Test()
        {
            int[] result = makeSquares(new int[] { -2, -1, 0, 2, 3 });
            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i] + " ");
            Console.WriteLine();

            result = makeSquares(new int[] { -3, -1, 0, 1, 2 });
            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i] + " ");
            Console.WriteLine();
        }
    }
}
