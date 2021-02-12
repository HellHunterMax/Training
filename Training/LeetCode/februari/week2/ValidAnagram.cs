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
            return SecondTry(s, t);
        }

        public static bool FirstTry(string s, string t)
        {
            s = String.Concat(s.OrderBy(c => c));
            t = String.Concat(t.OrderBy(c => c));

            if (s == t)
            {
                return true;
            }
            return false;
        }
        public static bool SecondTry(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> sDic = new Dictionary<char, int>();
            Dictionary<char, int> tDic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (sDic.ContainsKey(s[i]))
                {
                    sDic[s[i]]++;
                }
                else
                {
                    sDic.Add(s[i], 1);
                }

                if (tDic.ContainsKey(t[i]))
                {
                    tDic[t[i]]++;
                }
                else
                {
                    tDic.Add(t[i], 1);
                }
                
            }
            if (sDic.Count != tDic.Count)
            {
                return false;
            }
            foreach(var c in sDic)
            {
                if (tDic.ContainsKey(c.Key))
                {
                    if (tDic[c.Key] != c.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //Wrong! doesnt work because 1+ 3 = 4 and 2 + 2 = 4
        public static bool ThirdWithSollition(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                number += s[i];
                number -= t[i];
            }

            if (number != 0)
            {
                return false;
            }

            return true;
        }
    }
}
