
using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class FourSumAddToTarget
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var list = new List<IList<int>>();

            if (nums == null || nums.Length < 4)
            {
                return list;
            }

            var input = nums.OrderBy(i => i).ToArray();

            for (var i = 0; i < input.Count(); i++)
            {
                if (i > 0 && input[i] == input[i - 1])
                {
                    continue;
                }

                var threeTarget = target - input[i];
                var threeInput = input.Skip(i + 1);
                var threeSumResult = this.ThreeSum(threeInput.ToArray(), threeTarget);
                if (threeSumResult.Any())
                {
                    foreach (var ints in threeSumResult)
                    {
                        var res = new List<int> { input[i] };
                        res.AddRange(ints);
                        list.Add(res);
                    }
                }
            }

            return list;
        }

        private IList<IList<int>> ThreeSum(int[] nums, int target)
        {
            var list = new List<IList<int>>();
            
            var input = nums.OrderBy(i => i).ToArray();

            for (var i = 0; i < input.Count(); i++)
            {
                if (i > 0 && input[i] == input[i - 1])
                {
                    continue;
                }

                var low = i + 1;
                var high = input.Length - 1;

                while (low < high)
                {
                    if (input[low] + input[high] + input[i] == target)
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
                    else if (input[low] + input[high] + input[i] > target)
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
