using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class FruitsintoBaskets
    {
        public static int MaxFruitCountof2Types(char[] arr)
        {
            int max_Count = 0;
            int winStart = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int winEnd = 0; winEnd < arr.Length; winEnd++)
            {
                if(!dict.ContainsKey(arr[winEnd]))
                {
                    dict.Add(arr[winEnd], 1);
                }
                else
                {
                    dict[arr[winEnd]]++;
                }

                while(dict.Count > 2)
                {
                    if(Convert.ToInt32(dict[arr[winStart]]) == 1)
                    {
                        dict.Remove(arr[winStart]);
                    }
                    else
                    {
                        dict[arr[winStart]]--;
                    }
                    winStart++;
                }
                max_Count = Math.Max(max_Count, winEnd - winStart + 1);
            }
            return max_Count;

        }
        public static void Test()
        {
            char[] Fruit = { 'A', 'B', 'C', 'A', 'C' };
            Console.WriteLine(MaxFruitCountof2Types(Fruit));
        }
    }
}
