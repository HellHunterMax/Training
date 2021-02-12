using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.februari.week2
{
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            return FirstTry(s, t);
        }

        public static bool FirstTry(string s, string t)
        {
            var S = String.Concat(s.OrderBy(c => c));
            var T = String.Concat(t.OrderBy(c => c));

            if (S == T)
            {
                return true;
            }
            return false;
        }
    }
}
