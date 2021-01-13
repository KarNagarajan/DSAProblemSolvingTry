
using System.Collections.Generic;

namespace HandsOnTry.Medium
{
    using System.Linq;

    internal class ThreeSumAddToZero
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();

            if (nums == null || nums.Length < 3)
            {
                return list;
            }

            var input = nums.OrderBy(i => i).ToArray();

            for (var i = 0; i < input.Count() && input[i] <= 0; i++)
            {
                if (i > 0 && input[i] == input[i - 1])
                {
                    continue;
                }

                var low = i + 1;
                var high = input.Length - 1;

                while (low < high)
                {
                    if (input[low] + input[high] == 0 - input[i])
                    {
                        list.Add(new[] { input[i], input[low], input[high] });

                        do
                        {
                            low++;
                        }
                        while (low < high && input[low] == input[low - 1]);

                        do
                        {
                            high--;
                        }
                        while (high > low && input[high] == input[high + 1]);
                        
                    }
                    else if (input[low] + input[high] > 0 - input[i])
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }
                }
            }

            return list;
        }
    }
}
