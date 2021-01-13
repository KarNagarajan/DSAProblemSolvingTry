using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Easy
{
    internal class KMostFrequentElements
    {
        internal int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num] = dict[num] + 1;
                }
            }

            var orderedElements = dict.OrderByDescending(i => i.Value).Take(k);
            return orderedElements.Select(i => i.Key).ToArray();
        }
    }
}
