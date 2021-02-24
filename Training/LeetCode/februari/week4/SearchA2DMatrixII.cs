using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.februari.week4
{
    public static class SearchA2DMatrixII
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            return SlowSearch(matrix, target);
        }

        public static bool SlowSearch(int[][] matrix, int target)
        {
            foreach (var row in matrix)
            {
                if (row.Contains(target))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
