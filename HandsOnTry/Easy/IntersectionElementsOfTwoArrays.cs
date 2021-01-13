using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Easy
{
    internal class IntersectionElementsOfTwoArrays
    {
        internal int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return Enumerable.Empty<int>().ToArray();
            }

            var result = new List<int>();
            var values = new Dictionary<int, int>();

            foreach (var i in nums1)
            {
                if (values.ContainsKey(i))
                {
                    values[i] = values[i] + 1;
                }
                else
                {
                    values.Add(i, 1);
                }
            }

            foreach (var i in nums2)
            {
                if (values.ContainsKey(i) && values[i] > 0)
                {
                    values[i] = values[i] - 1;
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
    }
}