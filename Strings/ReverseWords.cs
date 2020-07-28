using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class ReverseWords
    {
        public static string strRev(char[] str, int start, int end)
        {

            while(start < end)
            {
                char temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
            return new string(str);
        }
        public static void reverseWords(string s)
        {
            char[] sen = s.ToCharArray();

            if(sen == null || sen.Length == 0)
            {
                return;
            }

            int len = sen.Length - 1;
            strRev(sen, 0, len);

            int start = 0;
            int end ;

            while(true)
            {
                while(sen[start] == ' ')
                {
                    start++;
                }
                if(start >= sen.Length - 1)
                {
                    break;
                }

                end = start + 1;
                while(end < sen.Length - 1 && sen[end] != ' ')
                {
                    end++;
                }
                strRev(sen, start, end-1);
                start = end;

            }
        }
        
        public static void Test()
        {
            string s = "Hello World!";
            Console.WriteLine(s);
            reverseWords(s);
            Console.WriteLine(s);

        }
    }
}
