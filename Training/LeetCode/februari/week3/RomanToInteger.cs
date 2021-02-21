using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week3
{
    public static class RomanToInteger
    {
        

        public static int RomanToInt(string s)
        {
            int count = 0;

            const int i = 1, v = 5, x = 10, l = 50, c = 100, d = 500, m = 1000;
            bool I = false, V = false, X = false, L = false, C = false, D = false;

            for (int j = s.Length -1; j >= 0; j--)
            {
                char letter = s[j];
                switch (letter)
                {
                    case 'I':
                        count = I ? count -= i : count += i;
                        break;
                    case 'V':
                        I = true;
                        count = V ? count -= v : count += v;
                        break;
                    case 'X':
                        I = true; V = true;
                        count = X ? count -= x : count += x;
                        break;
                    case 'L':
                        X = true;
                        count = L ? count -= l : count += l;
                        break;
                    case 'C':
                        X = true; L = true;
                        count = C ? count -= c : count += c;
                        break;
                    case 'D':
                        C = true;
                        count = D ? count -= d : count += d;
                        break;
                    case 'M':
                        C = true; D = true;
                        count += m;
                        break;
                }
            }
            return count;
        }
    }
}
