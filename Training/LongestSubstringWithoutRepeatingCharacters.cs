﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Get(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int newLength = SubStringLength(s.Substring(i));
                if (newLength > result)
                {
                    result = newLength;
                }
            }

            return result;
        }

        private static int SubStringLength(string s)
        {
            string checkedLetters = string.Empty;
            int subStringLength = 0;

            for (int i = 0; i < s.Length; i++ )
            {
                if (checkedLetters.Contains(s[i]))
                {
                    return subStringLength;
                }
                else
                {
                    checkedLetters += s[i];
                    subStringLength++;
                }
            }
            return subStringLength;
        }


    }
}
