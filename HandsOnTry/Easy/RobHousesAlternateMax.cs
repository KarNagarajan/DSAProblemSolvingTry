using System;

namespace HandsOnTry.Easy
{
    internal class RobHousesAlternateMax
    {
        internal int Rob(int[] nums)
        {
            // DP
            if (nums.Length == 0)
            {
                return 0;
            }

            var result = new int[nums.Length + 1];
            result[0] = 0;
            result[1] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                result[i + 1] = Math.Max(result[i], result[i - 1] + nums[i]);
            }

            return result[nums.Length - 1];
        }
    }
}
