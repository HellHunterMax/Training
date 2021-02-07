using System.Collections.Generic;
using System;

namespace Training.LeetCode.februari.week1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public static class BinaryTreeRightSideView
    {
        public static IList<int> RightSideView(TreeNode root)
        {
            return FirstTry(root);
        }

        public static IList<int> FirstTry(TreeNode root)
        {
            throw new NotImplementedException();
        }
    }
}
