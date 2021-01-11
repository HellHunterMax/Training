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
                if (list.Count == 0)
                {
                    list.Add(number);
                }
                else
                {
                    int start = 0;
                    int end = list.Count - 1;
                    int position = 0;

                    while (start <= end)
                    {

                        int mid = start + (end - start) / 2;

                        if (list[mid] == number)
                        {
                            list.Insert(Math.Max(0, mid + 1), number);

                            int firstIndex = list.IndexOf(number);
                            int lastIndex = list.LastIndexOf(number);

                            int distance = list.Count - 1 - lastIndex;

                            sum += firstIndex < distance ? firstIndex : distance;
                            break;
                        }

                        else if (list[mid] > number)
                        {
                            position = end = mid - 1;
                        }
                        else
                        {
                            position = start = mid + 1;
                        }
                        if (start > end)
                        {
                            position = start;
                            list.Insert(Math.Max(0, position), number);
                            int firstIndex = list.IndexOf(number);
                            int lastIndex = list.LastIndexOf(number);

                            int distance = list.Count - 1 - lastIndex;

                            sum += firstIndex < distance ? firstIndex : distance;
                            break;
                        }
                    }
                }
            }

            return sum;
        }

        public static int OriginalAnswer(int[] instructions)
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
        public static int CreateSortedArrayStolen(int[] instructions)
        {
            int cost = 0;
            int mod = (int)1e9 + 7;
            List<int> list = new List<int>();
            foreach (var number in instructions)
            {
                int start = 0, end = list.Count;
                while (start < end)
                {
                    int mid = start + (end - start) / 2;
                    if (list[mid] < number)
                        start = mid + 1;
                    else
                        end = mid;
                }

                int last = start; 
                end = list.Count;
                while (last < end)
                {
                    int mid = last + (end - last) / 2 + 1;
                    if (list[mid - 1] > number)
                        end = mid - 1;
                    else
                        last = mid;
                }
                cost += Math.Min(Math.Min(start, list.Count - start), Math.Min(last, list.Count - last));
                cost %= mod;
                list.Insert(start, number);
            }
            return cost;
        }


    }
}
