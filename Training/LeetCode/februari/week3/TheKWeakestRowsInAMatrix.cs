using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.februari.week3
{
    public static class TheKWeakestRowsInAMatrix
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            return Speedup(mat, k);
        }

        private static int[] FirstTry(int[][] mat, int k)
        {
            var rows = new Dictionary<int, int>();

            for (int i = 0; i < mat.Length; i++)
            {
                rows.Add(i,mat[i].Sum());
            }

            var sortedRows = (from row in rows
                              orderby row.Value
                              ascending
                              select row.Key).ToList();

            int[] weakestRows = new int[k];

            for (int i = 0; i < k; i++)
            {
                weakestRows[i] = sortedRows[i];
            }
            return weakestRows;
        }

        private static int[] Speedup(int[][] mat, int k)
        {
            var rows = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < mat.Length; i++)
            {
                int sum = mat[i].Sum();
                if (rows.Count >= k)
                {
                    if (sum < rows[rows.Count - 1].Value)
                    {
                        int index = FindIndex(rows, sum);
                        rows.Insert(index, new KeyValuePair<int, int>(i, sum));
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    rows.Add(new KeyValuePair<int, int>(i, sum));
                }
            }
            int[] weakestRows = new int[k];

            for (int i = 0; i < k; i++)
            {
                weakestRows[i] = rows[i].Key;
            }
            return weakestRows;

        }
        private static int FindIndex(List<KeyValuePair<int, int>> rows, int num)
        {
            for (int i = rows.Count -1; i >= 0; i++)
            {
                if (num <= rows.ElementAt(i).Value)
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}
