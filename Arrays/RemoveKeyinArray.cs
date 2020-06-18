using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class RemoveKeyinArray
    {
        public static int remove(int[] arr, int Key)
        {
            int nextElement = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != Key)
                {
                    arr[nextElement] = arr[i];
                    nextElement++;
                }
            }
            return nextElement;
        }
        public static void Test()
        {
            int[] arr = new int[] { 3, 2, 3, 6, 3, 10, 9, 3 };
            Console.WriteLine(remove(arr, 3));

            arr = new int[] { 2, 11, 2, 2, 1 };
            Console.WriteLine(remove(arr, 2));
        }
    }
}
