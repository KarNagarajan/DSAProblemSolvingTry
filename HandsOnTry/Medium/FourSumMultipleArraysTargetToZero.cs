using System.Collections.Generic;

namespace HandsOnTry.Medium
{
    internal class FourSumMultipleArraysTargetToZero
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var dict = new Dictionary<int, int>();
            var count = 0;

            foreach (var t in A)
            {
                foreach (var t1 in B)
                {
                    var sum = t + t1;
                    var key = 0 - sum;
                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, 1);
                    }
                    else
                    {
                        dict[key] = dict[key] + 1;
                    }
                }
            }

            foreach (var t in C)
            {
                foreach (var t1 in D)
                {
                    var key = t + t1;
                    if (dict.ContainsKey(key))
                    {
                        count += dict[key];
                    }
                }
            }

            return count;
        }
    }
}
