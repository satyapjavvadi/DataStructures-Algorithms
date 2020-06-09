using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class NoRepeatSubString
    {
        public static int findLength(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int winStart = 0, max_Length = 0;

            for(int winEnd = 0; winEnd < str.Length; winEnd++)
            {
                if(!dict.ContainsKey(str[winEnd]))
                {
                    dict.Add(str[winEnd], 1);
                }
                else
                {
                    dict.Remove(str[winStart]);
                    winStart = winEnd;
                }
                max_Length = Math.Max(max_Length, winEnd - winStart + 1);
            }
            return max_Length;
        }
        public static void Test()
        {
            Console.WriteLine(findLength("aabccbb"));
            Console.WriteLine(findLength("abbbb"));
            Console.WriteLine(findLength("abccde"));
        }
    }
}
