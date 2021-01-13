using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Easy
{
    internal class MajorityElementFind
    {
        internal int MajorityElement(int[] nums)
        {
            // Our solution
            var k = 0;
            var elementsByCount = new Dictionary<int, int>();

            while (k < nums.Length)
            {
                if (elementsByCount.ContainsKey(nums[k]))
                {
                    elementsByCount[nums[k]] = elementsByCount[nums[k]] + 1;
                }
                else
                {
                    elementsByCount.Add(nums[k], 1);
                }

                k++;
            }

            var maxOccurence = 0;
            foreach (var elt in elementsByCount)
            {
                if (elt.Value > maxOccurence)
                {
                    maxOccurence = elt.Value;
                }
            }

            return elementsByCount.First(j => j.Value == maxOccurence).Key;

            // Solution
            nums = nums.OrderBy(i => i).ToArray();
            return nums[nums.Length / 2];
        }
    }
}