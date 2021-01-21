using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Other
{
    public class Tree
    {
        public string[] XmasTree;

        public Tree(int height)
        {
            XmasTree = new string[height];
            BuildTree(height);
        }

        private void BuildTree(int height)
        {
            const char branch = '*';
            const char emptySpace = '-';
            int width = height * 2 - 1;

            for (int i = 0; i < height; i++)
            {
                int numberOfBranches = i * 2 + 1;
                int emptySidesSpace = (width - numberOfBranches) / 2;
                for (int k = 0; k < width; k++)
                {
                    if (emptySidesSpace > k || emptySidesSpace + numberOfBranches <= k )
                    {
                        XmasTree[i] += emptySpace;
                    }
                    else
                    {
                        XmasTree[i] += branch;
                    }
                }
            }
        }
    }
}
