using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Training.LeetCode.februari.week1;

namespace Training.LeetCode.februari.week2
{
    public static class ConvertBstToGreaterTree
    {
        public static TreeNode ConvertBST(TreeNode root)
        {
            return ThirdAfterSolution(root);
        }

        private static TreeNode FirstTry(TreeNode root)
        {
            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(CreateNode(root, 0));

            for (int i = 0; i < tree.Count; i++)
            {
                if (tree[i].Left != null)
                {
                    TreeNode node = CreateNode(tree[i].Left, tree[i].Val);
                    tree[i].Left = node;
                    tree.Add(node);
                }
                if (tree[i].Right != null)
                {
                    TreeNode node = CreateNode(tree[i].Right, 0); // 0 should be tree[i].Val nope....
                    tree[i].Right = node;
                    tree.Add(node);
                }
            }
            return tree[0];
        }

        private static TreeNode SecondTry(TreeNode root)
        {
            List<int> numbers = new List<int>();

            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(root);

            for (int i = 0; i < tree.Count; i++)
            {
                if (tree[i].Left != null)
                {
                    tree.Add(tree[i].Left);
                }
                if (tree[i].Right != null)
                {
                    tree.Add(tree[i].Right);
                }
            }
            foreach (var node in tree)
            {
                numbers.Add(node.Val);
            }
            foreach (var node in tree)
            {
                int val = node.Val;
                node.Val = (from x in numbers where x >= val select x).Sum();
            }

            return tree[0];
        }

        private static int sum = 0;

        public static TreeNode ThirdAfterSolution(TreeNode root)
        {
            if (root != null)
            {
                ThirdAfterSolution(root.Right);
                sum += root.Val;
                root.Val = sum;
                ThirdAfterSolution(root.Left);
            }
            return root;
        }

        private static TreeNode CreateNode(TreeNode root, int val)
        {
            TreeNode node = null;
            if (root.Right != null && root.Left != null)
            {
                node = new TreeNode((root.Val + More(root.Right) + val), root.Left, root.Right);
            }
            else if (root.Right != null)
            {
                node = new TreeNode((root.Val + More(root.Right) + val), null, root.Right);
            }
            else if (root.Left != null)
            {
                node = new TreeNode(root.Val + val, root.Left, null);
            }
            else
            {
                node = new TreeNode(root.Val + val);
            }
            return node;
        }

        private static int More(TreeNode root)
        {
            int sum = root.Val;
            if (root.Left != null)
            {
                sum += More(root.Left);
            }
            if (root.Right != null)
            {
                sum += More(root.Right);
            }
            return sum;
        }
    }
}
