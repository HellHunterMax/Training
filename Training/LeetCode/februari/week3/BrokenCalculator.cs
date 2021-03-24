using System;
using System.Collections.Generic;

namespace Training.LeetCode.februari.week3
{
    public static class BrokenCalculator
    {
        public static int Calculate(int X, int Y)
        {
            return SecondTry(X, Y);
        }

        private static int FirstTry(int X, int Y)
        {
            if (X > Y)
            {
                return Math.Abs(Y - X);
            }
            int count = 0;
            HashSet<int> hash = new HashSet<int>();
            int possibleCount = int.MaxValue;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(X);
            hash.Add(X);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                while (size-- > 0)
                {
                    int point = queue.Dequeue();
                    if (point == Y)
                    {
                        queue.Clear();
                        count--;
                        break;
                    }
                    else
                    {
                        if (point > Y)
                        {
                            possibleCount = (count + Math.Abs(Y - point));
                        }
                        else
                        {
                            int timesTwo = point * 2;
                            int minus1 = point - 1;
                            if (!hash.Contains(minus1) && minus1 > 1)
                            {
                                hash.Add(minus1);
                                queue.Enqueue(minus1);
                            }
                            if (timesTwo >= Y)
                            {
                                if (count + Math.Abs(Y - timesTwo) + 1 <= possibleCount)
                                {
                                    hash.Add(timesTwo);
                                    queue.Enqueue(timesTwo);
                                }
                            }
                            else
                            {
                                hash.Add(timesTwo);
                                queue.Enqueue(timesTwo);
                            }
                        }
                    }
                }
                count++;
            }

            return Math.Min(count, possibleCount);
        }

        public static int SecondTry(int X, int Y)
        {
            if (X >= Y)
            {
                return X- Y;
            }

            if (Y% 2 == 0)
            {
                return 1 + SecondTry(X, Y / 2);
            }

            return 1 + SecondTry(X, Y + 1);
        }
    }
}
