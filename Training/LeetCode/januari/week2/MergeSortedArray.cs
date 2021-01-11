using System.Linq;
using System;

namespace Training.LeetCode.januari.week2
{
    public class MergeSortedArray
    {
        private int[] _nums1;
        private int _m;
        private int[] _nums2;
        private int _n;

        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            _nums1 = nums1;
            _nums2 = nums2;
            _m = m;
            _n = n;

            return FirstMerge();
        }

        private int[] FirstMerge()
        {
            int j = 0;
            for (int i = _m; i < _nums1.Length; i++, j++)
            {
                _nums1[i] = _nums2[j];
            }

            Array.Sort(_nums1);

            return _nums1;
        }
    }
}
