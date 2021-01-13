using System.Linq;

namespace HandsOnTry.Easy
{
    using System.Collections.Generic;

    internal class TwoSumToGetTarget
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            var dict = new Dictionary<int, int>();

            var i = 0;

            while (i < nums.Length)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return new[] { dict[nums[i]], i };
                }

                dict.Add(target - nums[i], i);
                i++;
            }

            return result;
        }
    }
}
