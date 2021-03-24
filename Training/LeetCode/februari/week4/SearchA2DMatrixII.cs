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
            return ThirdTry(matrix, target);
        }
        public static bool ThirdTry(int[][] matrix, int target)
        {
            int left = 0, right = matrix[0].Length -1;
            int top = 0, bottom = matrix.Length -1;
            if (target > matrix[bottom][right] || target < matrix[top][left])
            {
                return false;
            }

            while (left <= right && top <= bottom)
            {
                int firstNumber = matrix[left][top];

                if (firstNumber == target)
                {
                    return true;
                }
                if (firstNumber < target)
                {
                    left++;
                    top++;
                    continue;
                }
                else
                {
                    left--;
                    top--;
                }
                break;
            }
            while (left <= right && top <= bottom)
            {

                int lastNumber = matrix[bottom][right];

                if (lastNumber == target)
                {
                    return true;
                }
                if (lastNumber > target)
                {
                    bottom--;
                    right--;
                    continue;
                }
                else
                {
                    bottom++;
                    right++;
                }
                break;
            }
            while (top <= bottom)
            {
                int l = left;
                int r = right;
                while (l <= r)
                {
                    if (matrix[top][l] == target ||
                        matrix[top][r] == target ||
                        matrix[bottom][l] == target||
                        matrix[bottom][r] == target )
                    {
                        return true;
                    }
                    else
                    {
                        l++;
                        r--;
                    }
                }
                top++;
                bottom--;
            }
            return false;
        }

        // All Wrong!
        public static bool SecondTry(int[][] matrix, int target)
        {
            //create two pointers for row
            //create two pointers for collumn
            // check if the last in the row is more then target;
            // check if last item in collumn is less then target;
            // if both are true target could be somewhere.
            // check if target is more then topleft

            if (matrix.Length == 0)
            {
                return false;
            }
            int numberPerRow = matrix[0].Length;
            int numberPerCollumn = matrix.Length;
            int row_Row = 0, row_Collumn = numberPerRow -1;
            int collumn_Row = numberPerCollumn - 1, collumn_Collumn = 0;
            if (matrix[collumn_Collumn][row_Collumn] < target)
            {
                return false;
            }
            int numbersToCheck = numberPerRow * numberPerCollumn;



            while (numbersToCheck > 0)
            {
                int c = matrix[collumn_Row][collumn_Collumn];
                if (c == target)
                {
                    return true;
                }
                else if (c < target)
                {
                    collumn_Collumn++;
                    numbersToCheck -= numberPerRow;
                    numberPerCollumn--;
                    continue;
                }

                int r = matrix[row_Row][row_Collumn];
                if(r == target)
                {
                    return true;
                }
                else if (r < target)
                {
                    row_Row++;
                    numbersToCheck -= numberPerCollumn;
                    numberPerRow--;
                    continue;
                }
                break;
            }
            while (numbersToCheck > 0)
            {
                int r = matrix[row_Collumn -1][collumn_Collumn];

                if (target == r)
                {
                    return true;
                }
                if (r > target)
                {
                    row_Collumn--;
                    numbersToCheck -= numberPerRow;
                    numberPerCollumn--;
                    continue;
                }

                int c = matrix[collumn_Collumn -1][row_Collumn];
                if (target == c)
                {
                    return true;
                }
                if (c > target)
                {
                    collumn_Collumn--;
                    numbersToCheck -= numberPerCollumn;
                    numberPerCollumn--;
                    continue;
                }
            }
            return false;
        }
        // Time Limit Exceeded To be Expected
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
