using System;
using System.Collections.Generic;
using System.Text;

namespace Training.HackerRank.Algorithm.Warmup
{
    public class CompareTheTriplets
    {
        private List<int> _alice;
        private List<int> _bob;

        public List<int> CompareTriplets(List<int> a, List<int> b)
        {
            _alice = a;
            _bob = b;

            return CalculateScore();
        }

        private List<int> CalculateScore()
        {
            List<int> score = new List<int>() { 0, 0};

            for (int i = 0; i < _alice.Count; i++)
            {
                if (_alice[i]> _bob[i])
                {
                    score[0]++;
                }
                else if (_alice[i] < _bob[i])
                {
                    score[1]++;
                }
            }

            return score;
        }
    }
}
