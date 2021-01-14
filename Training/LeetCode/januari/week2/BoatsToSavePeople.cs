using System.Collections.Generic;
using System.Linq;

namespace Training.LeetCode.januari.week2
{
    public static class BoatsToSavePeople
    {
        //https://leetcode.com/submissions/detail/442724472/?from=explore&item_id=3602
        public static int NumRescueBoats(int[] people, int limit)
        {
            return NumRescueBoatsOwn(people, limit);
        }
        public static int NumRescueBoatsOwn(int[] people, int limit)
        {
            int numberOfBoats = 0;

            List<int> peopleList = people.ToList();

            peopleList.Sort();

            while (peopleList.Count > 1)
            {
                int last = peopleList.Count - 1;
                numberOfBoats++;
                if (peopleList[0] +  peopleList[last] <= limit)
                {
                    peopleList.RemoveAt(0);
                    peopleList.RemoveAt(last -1);
                }
                else
                {
                    peopleList.RemoveAt(last);
                }
                
            }
            if (peopleList.Count == 1)
            {
                numberOfBoats++;
            }
            return numberOfBoats;
        }

        private static int NumRescueBoatsStolen(int[] people, int limit)
        {
            int numberOfBoats = 0;

            List<int> peopleList = people.ToList();

            peopleList.Sort();

            var lightestPersonIndex = 0;
            var heaviestPersonIndex = peopleList.Count - 1;
            while (lightestPersonIndex <= heaviestPersonIndex)
            {
                numberOfBoats++;
                if (peopleList[lightestPersonIndex] + peopleList[heaviestPersonIndex] <= limit)
                {
                    lightestPersonIndex++;
                }
                heaviestPersonIndex--;
            }
            return numberOfBoats;
        }
    }
}
