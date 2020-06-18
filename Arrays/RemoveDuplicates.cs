using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class RemoveDuplicates
    {
        public static int remove(int[] arr)
        {
            int nonDuplicate = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[nonDuplicate-1] != arr[i])
                {
                    arr[nonDuplicate] = arr[i];
                    nonDuplicate++;
                }
            }
            return nonDuplicate;
        }
        public static void Test()
        {
            int[] arr = new int[] { 2, 3, 3, 3, 6, 9, 9 };
            Console.WriteLine(remove(arr));

            arr = new int[] { 2, 2, 2, 11 };
            Console.WriteLine(remove(arr));
        }
    }
}
