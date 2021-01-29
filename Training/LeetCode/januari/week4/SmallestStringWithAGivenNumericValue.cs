using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week4
{
    public static class SmallestStringWithAGivenNumericValue
    {
        public static string GetSmallestString(int n, int k)
        {
            return ThirdTrySpeedup(n, k);
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

        private static string SecondTrySpeedup(int nLength, int kValue)
        {
            string final = String.Empty;
            int countOfZ = 0;
            while (kValue - nLength >= 26)
            {
                countOfZ++;
                kValue -= 26;
                nLength--;
            }

            int numberOfA = nLength - 1;
            kValue -= numberOfA;

            final += new string('a', numberOfA);
            final += Convert.ToChar(96 + kValue);
            final += new string('z', countOfZ);

            return final;
        }
        private static string ThirdTrySpeedup(int nLength, int kValue)
        {
            //Failed Attemt
            /*
             * value / 26 = z = aantal z dat erin passen; 
             * nLength - z = space = hoeveel ruimte er over is dus hoeveel aa's er moeten zijn.
             * if ( space > 1)
             * {
             *  z -= space
             * }
             * kValue -= (26 * z)
            */
            string final = String.Empty;
            int countOfZ = (kValue - nLength) / 26;
            kValue -= (26 * countOfZ);
            nLength -= countOfZ;
            while (kValue - nLength >= 26)
            {
                countOfZ++;
                kValue -= 26;
                nLength--;
            }
            if (nLength == 0)
            {
                return new string('z', countOfZ);
            }
            int numberOfA = nLength - 1;
            kValue -= numberOfA;

            final += new string('a', numberOfA);
            final += Convert.ToChar(96 + kValue);
            final += new string('z', countOfZ);

            return final;
        }
    }
}
