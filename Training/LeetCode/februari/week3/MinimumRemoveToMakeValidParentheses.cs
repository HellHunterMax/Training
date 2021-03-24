using System;

namespace Training.LeetCode.februari.week3
{
    public static class MinimumRemoveToMakeValidParentheses
    {
        public static string MinRemoveToMakeValid(string s)
        {
            return FirstTry(s);
        }


        public static string FirstTry(string s)
        {
            s = RemoveWrongChars(s, true);
            s = Reverse(s);
            s= RemoveWrongChars(s, false);
            return Reverse(s);
        }

        private static string RemoveWrongChars(string s, bool isForWard)
        {
            char openParetheses = '(';
            char closeParentheses = ')';

            if (!isForWard)
            {
                openParetheses = ')';
                closeParentheses = '(';
            }

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == openParetheses || c == closeParentheses)
                {
                    if (c == openParetheses)
                    {
                        count++;
                    }
                    else
                    {
                        if (RemoveChar(count))
                        {
                            s = s.Remove(i, 1);
                            i--;
                        }
                        else
                        {
                            count--;
                        }
                    }
                }
            }
            return s;
        }
        private static bool RemoveChar(int count)
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
