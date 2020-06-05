using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class LongestSubstringKdistinctChar
    {
        public static int findLength(string str, int K)
        {
            int maxLength = 0;
            int winStart = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int winEnd = 0; winEnd < str.Length; winEnd++)
            {
                if(!dict.ContainsKey(str[winEnd]))
                {
                    dict.Add(str[winEnd], 1);
                }
                else
                {
                    dict[str[winEnd]]++;
                }

                while (dict.Count > K)
                {
                    if((Convert.ToInt32(dict[str[winStart]]) == 1))
                    {
                        dict.Remove(str[winStart]);
                    }
                    else
                    {
                        dict[str[winStart]]--;
                    }
                    winStart++;
                }

                maxLength = Math.Max(maxLength, winEnd - winStart + 1);
            }
            return maxLength; 
        }
        public static void Test()
        {
            Console.WriteLine(findLength("araaci", 2));
            Console.WriteLine(findLength("araaci", 1));
            Console.WriteLine(findLength("cbbebi", 3));
        }
    }
}
