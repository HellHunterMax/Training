using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week1
{
    public static class SimplifyPath
    {
        public static string Simplify(string path)
        {
            return FirstTry(path);
        }

        /*
         * 
        ///// any number == /
        . == current lvl so can be deleted
        .. == one lvl back if possible
        .. > == path
        path starts with /
        no trailing /

        */

        private static string FirstTry(string path)
        {
            const string seperator = "/";
            const string back = "..";
            const string dot = ".";

            string command = string.Empty;
            string lastLetter = string.Empty;
            List<string> commandList = new List<string>();
            for (int i = 0; i < path.Length; i++)
            {
                string next = path[i].ToString();
                if ( next == seperator)
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
                else if (next == dot)
                {
                    if (lastLetter == dot)
                    {
                        command += next;
                        continue;
                    }
                    else if ( lastLetter != seperator)
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
                    if (lastLetter == seperator)
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
                if (commandList[i] == seperator || commandList[i] == dot)
                {
                    commandList.RemoveAt(i);
                    i--;
                }
                else if (commandList[i] == back)
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
            string simple = seperator;
            simple += String.Join(seperator, commandList);
            return simple;
        }
    }
}
