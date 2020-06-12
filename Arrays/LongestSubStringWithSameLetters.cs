using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class LongestSubStringWithSameLetters
    {
        public static void Test()
        {
            Console.WriteLine(findLongestSubString("aabccbb", 2));
            Console.WriteLine(findLongestSubString("abbcb", 1));
            Console.WriteLine(findLongestSubString("abccde", 1));
        }
        public static int findLongestSubString(string str, int k)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int winStart = 0;
            int longestSubstring = 0;

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

                while(dict.Count > 2)
                {
                    if(Convert.ToInt32(dict[str[winEnd]]) + k >= (winEnd - winStart +1))
                    {
                        longestSubstring = Math.Max(longestSubstring, winEnd - winStart + 1);
                    }
                    winStart++;
                    dict.Remove(str[winStart]);
                }
            }
            return longestSubstring;
        }
    }
}
