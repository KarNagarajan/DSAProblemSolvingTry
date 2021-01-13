using System;

namespace HandsOnTry.Easy
{
    internal class MaxSubArrayKadanesAlgo
    {
        internal int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var currentSum = nums[0];
            var maxSum = nums[0];

            for (var k = 1; k < nums.Length; k++)
            {
                currentSum = Math.Max(nums[k], currentSum + nums[k]);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            return maxSum;
        }
    }
}
