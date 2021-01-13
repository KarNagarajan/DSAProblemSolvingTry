using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.BacktrackingTry
{
    internal class PerumtationOfArrayElementsTry
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            this.BackTrackPermute(nums, new List<int>(), result);
            return result;
        }

        private void BackTrackPermute(int[] nums, List<int> tempResult, List<IList<int>> result)
        {
            if (!nums.Any())
            {
                result.Add(tempResult.ToArray());
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var tempNums = nums.Where(x => x != nums[i]).ToArray();
                tempResult.Add(nums[i]);
                this.BackTrackPermute(tempNums, tempResult, result);
                tempResult.Remove(tempResult.Last());
            }
        }
    }
}
