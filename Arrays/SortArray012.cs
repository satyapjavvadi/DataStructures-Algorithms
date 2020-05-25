using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SortArray012
    {
        public static void SortedArraywith012(int[] arr)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while(mid <= high)
            {
                switch(arr[mid])
                {
                    case 0:
                        if(arr[low] != arr[mid])
                        {
                            int temp = arr[low];
                            arr[low] = arr[mid];
                            arr[mid] = temp;
                        }
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        if(arr[mid] != arr[high])
                        {
                            int temp = arr[mid];
                            arr[mid] = arr[high];
                            arr[high] = temp;
                        }
                        high--;
                        break;
                }
            }

        }
        public static void Test()
        {
            int[] arr = { 0, 1, 1, 0, 2, 2, 1, 0, 2 };
            SortedArraywith012(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
