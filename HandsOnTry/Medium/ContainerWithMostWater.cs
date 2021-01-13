using System;

namespace HandsOnTry.Medium
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var low = 0;
            var high = height.Length - 1;
            var maxCapacity = 0;

            while (low < high)
            {
                if (height[low] < height[high])
                {
                    maxCapacity = Math.Max(maxCapacity, (high - low) * height[low]);
                    low++;
                }
                else
                {
                    maxCapacity = Math.Max(maxCapacity, (high - low) * height[high]);
                    high--;
                }
            }

            return maxCapacity;
        }
    }
}
