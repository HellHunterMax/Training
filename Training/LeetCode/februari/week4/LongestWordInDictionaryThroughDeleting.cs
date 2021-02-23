using System;
using System.Collections.Generic;

namespace Training.LeetCode.februari.week4
{
    public static class LongestWordInDictionaryThroughDeleting
    {
        const int longer = 1;
        const int sameLength = 0;
        const int shorter = -1;
        public static string FindLongestWord(string s, IList<string> d)
        {
            string finalWord = String.Empty;
            var dic = BuildDictionaryFromWord(s);

            foreach (var word in d)
            {
                int isWordLonger = IsWord2Longer(finalWord, word);
                if (isWordLonger == longer)
                {
                    var wordDic = BuildDictionaryFromWord(word);
                    if (DoesWordFitInDictionary(dic, wordDic))
                    {
                        finalWord = word;
                    }
                }
                else if (isWordLonger == sameLength)
                {
                    var wordDic = BuildDictionaryFromWord(word);
                    if (DoesWordFitInDictionary(dic, wordDic))
                    {
                        if (IsWord2lexicographicallySmaller(finalWord, word))
                        {
                            finalWord = word;
                        }
                    }
                }
                else if (isWordLonger == shorter)
                {
                    continue;
                }
            }

            return finalWord;
        }

        /// <summary>
        /// Checks if word 2 is longer or same length;
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns>1 if its longer, 0 for same length, -1 shorter</returns>
        private static int IsWord2Longer(string one, string two)
        {
            if (one.Length < two.Length)
            {
                return 1;
            }
            else if (one.Length == two.Length)
            {
                return 0;
            }
            return -1;
        }

        private static bool IsWord2lexicographicallySmaller(string word1, string word2)
        {
            if (word1 == word2)
            {
                return false;
            }
            for (int i = 0; i < word1.Length; i++)
            {
                if (word2[i] < word1[i])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool DoesDictionaryContainEnoughLettersForWord(Dictionary<char, int> dic, Dictionary<char, int> word)
        {
            return dic.Count >= word.Count;
        }

        private static bool DoesWordFitInDictionary(Dictionary<char, int> dic, Dictionary<char, int> word)
        {
            if (!DoesDictionaryContainEnoughLettersForWord(dic, word))
            {
                return false;
            }

            foreach (var letter in word)
            {
                if (!dic.ContainsKey(letter.Key))
                {
                    return false;
                }
                else
                {
                    if (letter.Value > dic[letter.Key])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static Dictionary<char, int> BuildDictionaryFromWord(string word)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (dic.ContainsKey(letter))
                {
                    dic[letter]++;
                }
                else
                {
                    dic.Add(letter, 1);
                }
            }
            return dic;
        }
    }
}
