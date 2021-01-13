using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Training.LeetCode.januari.week2
{
    //https://leetcode.com/explore/challenge/card/january-leetcoding-challenge-2021/580/week-2-january-8th-january-14th/3601/

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class AddTwoLinkedListNumbers
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbersSecond(l1, l2);
        }

        public ListNode AddTwoNumbersFirst(ListNode l1, ListNode l2)
        {
            string number1 = string.Empty;
            string number2 = string.Empty;

            while (l1 != null)
            {
                number1 += l1.val;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                number2 += l2.val;
                l2 = l2.next;
            }
            number1 = Reverse(number1);
            number2 = Reverse(number2);
            string sum = ((BigInteger.Parse(number1)) + (BigInteger.Parse(number2))).ToString();

            List<ListNode> listOfNodes = new List<ListNode>();

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                listOfNodes.Add(new ListNode(int.Parse(sum[i].ToString())));

            }
            for (int i = 0; i < listOfNodes.Count - 1; i++)
            {
                listOfNodes[i].next = listOfNodes[i + 1];
            }

            return listOfNodes[0];
        }
        public ListNode AddTwoNumbersSecond(ListNode l1, ListNode l2)
        {
            string sum = String.Empty;

            bool remain = false;
            while ( l1 != null && l2 != null)
            {
                int num = l1.val + l2.val;
                if (remain)
                {
                    num += 1;
                    remain = false;
                }
                if (num >9)
                {
                    num -= 10;
                    remain = true;
                }
                sum += num;
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null)
            {
                int num = l1.val;
                if (remain)
                {
                    num += 1;
                    remain = false;
                }
                if (num > 9)
                {
                    num -= 10;
                    remain = true;
                }
                sum += num;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                int num = l2.val;
                if (remain)
                {
                    num += 1;
                    remain = false;
                }
                if (num > 9)
                {
                    num -= 10;
                    remain = true;
                }
                sum += num;
                l2 = l2.next;
            }
            if (remain)
            {
                sum += 1;
            }
            List<ListNode> listOfNodes = new List<ListNode>();

            for (int i = 0; i < sum.Length; i++)
            {
                listOfNodes.Add(new ListNode(int.Parse(sum[i].ToString())));

            }
            for (int i = 0; i < listOfNodes.Count - 1; i++)
            {
                listOfNodes[i].next = listOfNodes[i + 1];
            }

            return listOfNodes[0];
        }

            public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
