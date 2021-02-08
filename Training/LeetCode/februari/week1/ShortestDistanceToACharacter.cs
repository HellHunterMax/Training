using System;

namespace Training.LeetCode.februari.week1
{
    public static class ShortestDistanceToACharacter
    {
        public static int[] ShortestToChar(string s, char c)
        {
            return FirstTry(s, c);
        }

        private static int[] FirstTry(string s, char c)
        {
            int[] arrF = new int[s.Length];
            int[] arrB = new int[s.Length];

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string r = new string(charArray);

            for (int i = 0; i < s.Length; i++)
            {
                arrF[i] = s.IndexOf(c, i) - i;
                arrB[i] = r.IndexOf(c, i) - i;
            }

            Array.Reverse(arrB);
            int[] final = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (arrF[i] < 0)
                {
                    final[i] = arrB[i];
                }
                else if (arrB[i] < 0)
                {
                    final[i] = arrF[i];
                }
                else
                {
                    final[i] = arrF[i] < arrB[i] ? arrF[i] : arrB[i];
                }
            }
            return final;
        }
    }
}
