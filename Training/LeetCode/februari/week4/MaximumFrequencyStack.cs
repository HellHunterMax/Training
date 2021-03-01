using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.LeetCode.februari.week4
{
    public static class MaximumFrequencyStack
    {
    }

    public class FreqStack
    {
        private List<int> _numbers;
        private Dictionary<int, int> _dic;

        public FreqStack()
        {
            _numbers = new List<int>();
            _dic = new Dictionary<int, int>();
        }

        public void Push(int x)
        {
            _numbers.Add(x);
            if(_dic.ContainsKey(x))
            {
                _dic[x]++;
            }
            else
            {
                _dic.Add(x, 1);
            }
        }

        public int Pop()
        {
            int lastIndex = -1;
            int chosenNumber = -1;
            var numbers = FindMostNumbersWithoutSorting();

            foreach (var number in numbers)
            {
                int index = _numbers.LastIndexOf(number);

                if(lastIndex < index)
                {
                    lastIndex = index;
                    chosenNumber = number;
                }
            }

            _dic[chosenNumber]--;
            if (_dic[chosenNumber] == 0)
            {
                _dic.Remove(chosenNumber);
            }
            _numbers.RemoveAt(lastIndex);

            return chosenNumber;
        }
        /*
        private List<int> FindMostNumbers()
        {
            List<int> numbers = new List<int>();
            int freq = _dic.First().Value;

            foreach (var pair in _dic)
            {
                if (pair.Value == freq)
                {
                    numbers.Add(pair.Key);
                }
                else
                {
                    break;
                }
            }
            return numbers;
        }
        */
        private List<int> FindMostNumbersWithoutSorting()
        {
            int freq = _dic.Values.Max();

            List<int> numbers = (from pair in _dic
                       where pair.Value == freq
                       select pair.Key).ToList();

            return numbers;
        }
        /*
        private void Sort_dic()
        {
            _dic = (Dictionary<int, int>)(from pair in _dic
                   orderby pair.Value descending
                   select pair).ToDictionary(pair => pair.Key, pair => pair.Value);
        }*/
    }
}
