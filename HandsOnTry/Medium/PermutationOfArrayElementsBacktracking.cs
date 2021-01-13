using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class PermutationOfArrayElementsBacktracking
    {
        internal IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var tempResult = new List<int>();
            return this.GetPermutedArrayElements(nums, tempResult, result);
        }

        private IList<IList<int>> GetPermutedArrayElements(int[] nums, IList<int> tempResult, List<IList<int>> result)
        {
            if (!nums.Any())
            {
                result.Add(tempResult.ToList());
            }

            for (var k = 0; k < nums.Length; k++)
            {
                var nums1 = nums.Where(i => i != nums[k]).ToArray();
                tempResult.Add(nums[k]);
                this.GetPermutedArrayElements(nums1, tempResult, result);
                tempResult.Remove(tempResult.Last());
            }

            return result;
        }
    }
}
