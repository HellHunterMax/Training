using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week2
{
    public static class CreateSortedArrayThroughInstructions
    {
        public static int CreateSortedArray(int[] instructions)
        {
            int sum = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < instructions.Length; i++)
            {
                int number = instructions[i];
                list.Add(number);
                list.Sort();
                int firstIndex = list.IndexOf(number);
                int lastIndex = list.LastIndexOf(number);

                int distance = list.Count - 1 - lastIndex;

                sum += firstIndex < distance ? firstIndex : distance;
            }

            return sum;
        }
    }
}
