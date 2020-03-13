using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class BubbleSort
    {
        //Program to count how many swaps are happened in bubble sort
        public void countSwaps(int[] a)
        {
            int count = 0;
            int n = a.Length;

            for(int i = 0; i < n; i++)
            {
                for (int j = i; j < n-1; j++)
                {
                    if(a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                    }                   
                }                
            }
            Console.WriteLine($"Array is sorted in {count} swaps");
        }


        public static void Test()
        {
            int[] a = { 3, 2, 1 };

            BubbleSort b = new BubbleSort();
            b.countSwaps(a);

        }
    }
}
