using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.januari.week4
{
    public static class DetermineIfTwoStringsAreClose
    {
        public static bool CloseStrings(string word1, string word2)
        {
            //Sort Letters Alphabetticaly, if the amout = the same is true;
            if (word1.Length != word2.Length)
            {
                return false;
            }
            var frequency1 = from f in word1
                            group f by f into letterfrequency
                            orderby letterfrequency.Count()
                            select new
                            {
                                Letter = letterfrequency.Key,
                                Frequency = letterfrequency.Count()
                            };
            var frequency2 = from f in word2
                            group f by f into letterfrequency
                            orderby letterfrequency.Count()
                            select new
                            {
                                Letter = letterfrequency.Key,
                                Frequency = letterfrequency.Count()
                            };
            var frequency1List = frequency1.ToList();
            var frequency2List = frequency2.ToList();
            for (int i = 0; i < frequency1List.Count; i++)
            {
                if (frequency2List.FirstOrDefault(x => x.Letter == frequency1List[i].Letter) == null || frequency1List.FirstOrDefault(x => x.Letter == frequency2List[i].Letter) == null)
                {
                    return false;
                }
                if (frequency1List[i].Frequency != frequency2List[i].Frequency)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
