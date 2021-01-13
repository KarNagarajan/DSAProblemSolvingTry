using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.BacktrackingTry
{
    internal class SubsetsForArrayTry
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            this.BackTrackSubset(nums, new List<int>(), result, 0, nums.Length);
            return result;
        }

        private void BackTrackSubset(int[] nums, IList<int> tempResult, List<IList<int>> result, int startIndex, int endIndex)
        {
            result.Add(tempResult.ToArray());

            for (var k = startIndex; k < endIndex; k++)
            {
                tempResult.Add(nums[k]);
                this.BackTrackSubset(nums, tempResult, result, k + 1, endIndex);
                tempResult.Remove(tempResult.Last());
            }
        }
    }
}
