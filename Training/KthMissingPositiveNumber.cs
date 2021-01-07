using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public static class KthMissingPositiveNumber
    {
        public static int FindKthPositive(int[] arr, int k)
        {
            int finalNumber = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int numberArrINeedsToBe = i + count + 1;
                if (arr[i] != numberArrINeedsToBe)
                {
                    int addToCount = arr[i] - numberArrINeedsToBe;

                    if (count + addToCount >= k)
                    {
                        addToCount = k - count;
                        finalNumber += addToCount;
                        return finalNumber;
                    }
                    else
                    {
                        count += addToCount;
                    }
                }
                finalNumber = arr[i];
            }

            finalNumber += (k - count);

            return finalNumber;
        }
    }
}
