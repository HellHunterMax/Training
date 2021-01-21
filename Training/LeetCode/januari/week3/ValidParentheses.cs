using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week3
{
    //https://leetcode.com/problems/valid-parentheses
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            return SecondTry(s);
        }

        const int Parentheses = 1;
        const int Braces = 2;
        const int Brackets = 3;

        private static bool FirstTry(string s)
        {
            string ns = s;
            int contains = CheckForParentheses(ns);

            while (contains > 0)
            {
                if (contains == Parentheses)
                {
                    ns = ns.Replace("()", "");
                    contains = CheckForParentheses(ns);

                }
                else if (contains == Braces)
                {
                    ns = ns.Replace("{}", "");
                    contains = CheckForParentheses(ns);
                }
                else
                {
                    ns = ns.Replace("[]", "");
                    contains = CheckForParentheses(ns);
                }
            }
            if (ns.Length > 0)
            {
                return false;
            }
                
            return true;
        }

        private static bool SecondTry(string s)
        {
            Dictionary<char, char> dictionary = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            Stack<char> stack = new Stack<char>();

            foreach (char letter in s)
            {
                if (dictionary.ContainsKey(letter))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack.Peek() == dictionary[letter])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(letter);
                }
            }
            if (stack.Count >0)
            {
                return false;
            }
            return true;
        }
        private static int CheckForParentheses(string s)
        {
            if (s.Contains("{}"))
            { return Braces; }
            if (s.Contains("[]"))
            { return Brackets; }
            if (s.Contains("()"))
            { return Parentheses; }
            return -1;
        }
    }
}
