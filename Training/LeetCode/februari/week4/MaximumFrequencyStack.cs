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
        private Dictionary<int, int> _numbersWithFrequencys;
        private Dictionary<int, Stack<int>> _frequencysWithNumbersStack;
        private int _maxFrequency = 0;

        public FreqStack()
        {
            _numbersWithFrequencys = new Dictionary<int, int>();
            _frequencysWithNumbersStack = new Dictionary<int, Stack<int>>();
        }

        public void Push(int x)
        {
            if(_numbersWithFrequencys.ContainsKey(x))
            {
                _numbersWithFrequencys[x]++;
            }
            else
            {
                _numbersWithFrequencys.Add(x, 1);
            }
            if (_frequencysWithNumbersStack.ContainsKey(_numbersWithFrequencys[x]))
            {
                _frequencysWithNumbersStack[_numbersWithFrequencys[x]].Push(x);
            }
            else
            {
                _frequencysWithNumbersStack.Add(_numbersWithFrequencys[x], new Stack<int>());
                _frequencysWithNumbersStack[_numbersWithFrequencys[x]].Push(x);
            }
            if (_numbersWithFrequencys[x] > _maxFrequency)
            {
                _maxFrequency = _numbersWithFrequencys[x];
            }
        }

        public int Pop()
        {
            int chosenNumber = _frequencysWithNumbersStack[_maxFrequency].Pop();
            _numbersWithFrequencys[chosenNumber]--;

            if(_frequencysWithNumbersStack[_maxFrequency].Count == 0)
            {
                _frequencysWithNumbersStack.Remove(_maxFrequency);
                _maxFrequency--;
            }

            return chosenNumber;
        }
    }
}
