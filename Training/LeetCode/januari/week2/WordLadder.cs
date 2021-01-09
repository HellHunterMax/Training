using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.januari.week2
{
    //Breadth First Search
    public static class WordLadder
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int endIndex = wordList.IndexOf(endWord);

            if (endIndex < 0)
            {
                return 0;
            }

            return 0;
        }

        public static List<List<string>> FindListOfPossibleTransformations(string beginWord, string endWord, IList<string> wordList)
        {
            List<List<string>> possibleTransformationStrings = new List<List<string>>();

            List<string> possible = FindPossibleTransformations(beginWord, endWord, wordList, new List<string>());

            if (possible.Count < 1)
            {
                return possibleTransformationStrings;
            }

            foreach (string word in possible)
            {
                possibleTransformationStrings.Add(new List<string>() { word });
            }

            bool TransformationsArePossible = true;

            while (TransformationsArePossible)
            {
                foreach (List<string> list in possibleTransformationStrings)
                {
                    List<string> possible2 = FindPossibleTransformations(list[list.Count], endWord, wordList, list);
                }
            }
            return possibleTransformationStrings;
        }

        public static List<string> FindPossibleTransformations(string currentWord, string endWord, IList<string> wordList, List<string> usedWords)
        {
            List<string> possibleTransformationWords = new List<string>();

            foreach ( string word in wordList)
            {
                if (usedWords.Contains(word))
                {
                    continue;
                }
                if (isTransformationPossible(currentWord, word))
                {
                    possibleTransformationWords.Add(word);
                }
            }
            return possibleTransformationWords;
        }

        public static bool isTransformationPossible(string word1, string word2)
        {
            if (word1 == word2)
            {
                return false;
            }

            int numberOfChanges = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    numberOfChanges++;
                    if (numberOfChanges >1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
