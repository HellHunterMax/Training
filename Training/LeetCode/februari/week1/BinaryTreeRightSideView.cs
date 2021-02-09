using System.Collections.Generic;
using System;

namespace Training.LeetCode.februari.week1
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
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
            List<List<TreeNode>> tree = new List<List<TreeNode>>();

            if (root == null)
            {
                return new int[0];
            }

            tree.Add(new List<TreeNode> { root });
            for (int i = 0; i < tree.Count; i++)
            {
                List<TreeNode> treeNodes = GetTreeNodes(tree[i]);
                if (treeNodes.Count == 0)
                {
                    break;
                }
                tree.Add(treeNodes);
            }
            int[] rightSideView = new int[tree.Count];
            for (int i = 0; i < tree.Count; i++)
            {
                rightSideView[i] = tree[i][tree[i].Count - 1].Val;
            }
            return rightSideView;

        }

        private static List<TreeNode> GetTreeNodes(List<TreeNode> nodes)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (TreeNode node in nodes)
            {
                TreeNode l = node.Left;
                TreeNode r = node.Right;
                if (l != null)
                {
                    treeNodes.Add(l);
                }
                if (r != null)
                {
                    treeNodes.Add(r);
                }
            }
            return treeNodes;
        }
    }
}
