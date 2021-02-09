using System;
using System.Collections.Generic;
using System.Text;
using Training.LeetCode.februari.week1;
using Training.LeetCode.februari.week2;
using Xunit;

namespace TrainingTests.LeetCode.februari.week2
{
    public class ConvertBstToGreaterTreeTests
    {
        [InlineData(new int[] { 3, 3, 2 }, new int[] { 1, 0, 2 })]
        [InlineData(new int[] { 1, -1, 1 }, new int[] { 0, -1, 1 })]
        [InlineData(new int[] { 30, 36, 21, 36, 35, 26, 15, -1, -1, -1, 33, -1, -1, -1, 8 }, new int[] { 4, 1, 6, 0, 2, 5, 7, -1, -1, -1, 3, -1, -1, -1, 8 })]
        [Theory]
        public void ConvertBstToGreaterTree_Given_BSTTree_ReturnsGreaterTree(int[] expected, int[] treeArr)
        {
            var root = ConvertBstToGreaterTree.ConvertBST(GetTreeRoot(treeArr));
            var actual = TurnTreeToInt(root);

            Assert.Equal(expected, actual);

        }

        private int[] TurnTreeToInt(TreeNode treeNode)
        {
            List<List<TreeNode>> tree = new List<List<TreeNode>>();

            if (treeNode == null)
            {
                return new int[0];
            }

            tree.Add(new List<TreeNode> { treeNode });
            for (int i = 0; i < tree.Count; i++)
            {
                List<TreeNode> treeNodes = GetTreeNodes(tree[i]);
                bool isTreeGrowing = false;
                foreach (TreeNode node in treeNodes)
                {
                    if (node.Val > -1)
                    {
                        isTreeGrowing = true;
                        break;
                    }
                }
                if (!isTreeGrowing)
                {
                    break;
                }
                tree.Add(treeNodes);
            }
            List<int> treeArr = new List<int>();

            for (int i = 0; i < tree.Count; i++)
            {
                for (int j = 0; j < tree[i].Count; j++)
                {
                    treeArr.Add(tree[i][j].Val);
                }
            }

            return treeArr.ToArray();
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
                else
                {
                    treeNodes.Add(new TreeNode(-1));
                }
                if (r != null)
                {
                    treeNodes.Add(r);
                }
                else
                {
                    treeNodes.Add(new TreeNode(-1));
                }
            }
            return treeNodes;
        }

        private TreeNode GetTreeRoot(int[] treeArr)
        {
            List<TreeNode> tree = new List<TreeNode>();
            foreach (int node in treeArr)
            {
                tree.Add(new TreeNode(node));
            }
            int nodeCount = 0;
            for (int i = 1; i < tree.Count; i++)
            {
                if (tree[i].Val < 0)
                {
                    if (i % 2 == 0)
                    {
                        nodeCount++;
                    }
                    continue;
                }
                if (i % 2 == 0)
                {
                    tree[nodeCount].Right = tree[i];
                    if (i % 2 == 0)
                    {
                        nodeCount++;
                    }
                }
                else
                {
                    tree[nodeCount].Left = tree[i];
                    if (i % 2 == 0)
                    {
                        nodeCount++;
                    }
                }
            }
            return tree[0];
        }
    }
}
