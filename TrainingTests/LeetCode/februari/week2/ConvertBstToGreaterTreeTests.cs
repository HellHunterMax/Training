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
        [InlineData(new int[] { 7, 9, 4, 10 }, new int[] { 3, 2, 4, 1 })]
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
                bool isTreeGrowing = true;
                foreach (TreeNode node in treeNodes)
                {
                    if (node.val > -1)
                    {
                        isTreeGrowing = false;
                    }
                }
                if (!isTreeGrowing)
                {
                    break;
                }
                tree.Add(treeNodes);
            }
            List<int> treeArr = new List<int>();

            int treeI = 0;

            for (int i = 0; i < tree.Count; i++)
            {
                for (int j = 0; j < tree[i].Count; j++)
                {
                    treeArr[treeI] = tree[i][j].val;
                }
            }

            return treeArr.ToArray();
        }
        private static List<TreeNode> GetTreeNodes(List<TreeNode> nodes)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (TreeNode node in nodes)
            {
                TreeNode l = node.left;
                TreeNode r = node.right;
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
                if (tree[i].val < 0)
                {
                    if (i % 2 == 0)
                    {
                        nodeCount++;
                    }
                    continue;
                }
                if (i % 2 == 0)
                {
                    tree[nodeCount].right = tree[i];
                    if (i % 2 == 0)
                    {
                        nodeCount++;
                    }
                }
                else
                {
                    tree[nodeCount].left = tree[i];
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
