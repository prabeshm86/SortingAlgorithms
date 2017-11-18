using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class LongestPalindrome
    {
        static string longestPalindromeSubstr(string s)
        {
            //var arr = s.ToCharArray();
            var max = s.Substring(0, 1);

            for (int i = 0; i < s.Length; i++)
            {

                for (int j = i; j < s.Length; j++)
                {
                    var str = s.Substring(i, j - i);
                    if (IsPalindrome(str))
                        if (str.Length > max.Length)
                            max = str;
                }
            }

            return "\"" + max + "\"";

        }

        static bool IsPalindrome(string myString)
        {
            return myString.SequenceEqual(myString.Reverse());
        }
    }
}
