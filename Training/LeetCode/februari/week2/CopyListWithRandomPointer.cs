using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week2
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public static class CopyListWithRandomPointer
    {
        public static Node CopyRandomList(Node head)
        {
            return FirstTry(head);
        }

        private static Node FirstTry(Node head)
        {
            if (head == null)
            {
                return null;
            }

            List<Node> original = new List<Node>();
            List<Node> nodes = new List<Node>();

            Node next = head;
            while(next != null)
            {
                Node newNode = new Node(next.val);
                nodes.Add(newNode);
                original.Add(next);
                next = next.next;
            }
            for (int i = 0; i < nodes.Count; i++)
            {
                if (i != 0)
                {
                    nodes[i - 1].next = nodes[i];
                }
                if (original[i].random == null)
                {
                    continue;
                }

                int num = original.IndexOf(original[i].random);

                nodes[i].random = nodes[num];
            }

            return nodes[0];
        }
    }
}
