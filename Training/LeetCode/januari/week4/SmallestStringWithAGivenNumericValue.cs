using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week4
{
    public static class SmallestStringWithAGivenNumericValue
    {
        public static string GetSmallestString(int n, int k)
        {
            return FirstTry(n, k);
        }

        public static string FirstTry(int nLength, int kValue)
        {
            string final = String.Empty;
            while (kValue - nLength >= 26)
            {
                final += "z";
                kValue -= 26;
                nLength--;
            }
            int numberOfA = 0;

            while(nLength > 1)
            {
                numberOfA++;
                kValue--;
                nLength--;
            }
            
            final += Convert.ToChar(96 + kValue);

            while (numberOfA > 0)
            {
                final += "a";
                numberOfA--;
            }
            final = Reverse(final);

            return final;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
