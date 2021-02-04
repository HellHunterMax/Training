using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x)
        {
            val = x;
            next = null;
                 }
  }
    public static class LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            ListNode node = head;
            List<ListNode> listOfNodes = new List<ListNode>();
            while(node.next != null)
        {
                listOfNodes.Add(node);
            if (listOfNodes.Contains(node.next))
                {
                    return true;
                }
                node = node.next;
            }
            return false;
        }
    }
}
