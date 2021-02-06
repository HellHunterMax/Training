using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class SimplifyPath
    {
        private const string _seperator = "/";
        private const string _back = "..";
        private const string _dot = ".";

        public static string Simplify(string path)
        {
            return FirstTry(path);
        }
        private static string FirstTry(string path)
        {
            List<string> commandList = GetCommandList(path);
            
            string simple = _seperator;
            simple += String.Join(_seperator, commandList);
            return simple;
        }

        private static List<string> GetCommandList(string path)
        {
            string command = string.Empty;
            string lastLetter = string.Empty;
            List<string> commandList = new List<string>();

            for (int i = 0; i < path.Length; i++)
            {
                string next = path[i].ToString();
                if (next == _seperator)
                {
                    if (lastLetter == "")
                    {
                    }
                    else
                    {
                        commandList.Add(command);
                        command = next;
                        lastLetter = next;
                    }
                }
                else if (next == _dot)
                {
                    if (lastLetter == _dot)
                    {
                        command += next;
                        continue;
                    }
                    else if (lastLetter != _seperator)
                    {
                        command += next;
                        lastLetter = next;
                        continue;
                    }
                    else
                    {
                        commandList.Add(command);
                        command = next;
                        lastLetter = next;
                    }
                }
                else
                {
                    if (lastLetter == _seperator)
                    {
                        commandList.Add(command);
                        command = next;
                        lastLetter = next;
                    }
                    else
                    {
                        command += next;
                        lastLetter = next;
                        continue;
                    }
                }
            }
            commandList.Add(command);
            for (int i = 0; i < commandList.Count; i++)
            {
                if (commandList[i] == _seperator || commandList[i] == _dot)
                {
                    commandList.RemoveAt(i);
                    i--;
                }
                else if (commandList[i] == _back)
                {
                    if (i > 0)
                    {
                        commandList.RemoveRange(i - 1, 2);
                        i -= 2;
                    }
                    else
                    {
                        commandList.RemoveAt(i);
                        i--;
                    }
                }
            }
            return commandList;
        }
    }
}
