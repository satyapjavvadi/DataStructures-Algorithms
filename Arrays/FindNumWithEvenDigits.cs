using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class FindNumWithEvenDigits
    {
        public static int FindNumbers(int[] arr)
        {
            int count = 0, evenDigits = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                while(num > 0)
                {
                    count++;
                    num = num / 10;
                }
                if(count % 2 == 0)
                {
                    evenDigits++;
                }
            }
            return evenDigits;
        }
        public static void Test()
        {
            int[] arr = { 12, 345, 2, 6, 7896 };
            int evenNumberDigits = FindNumbers(arr);
            Console.WriteLine(evenNumberDigits);
        }
    }
}
