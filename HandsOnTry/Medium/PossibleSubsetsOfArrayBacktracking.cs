using System.Collections.Generic;

namespace HandsOnTry.Medium
{
    internal class PossibleSubsetsOfArrayBacktracking
    {
        // Our Solution - BruteForce - Cascading Approach

        //public IList<IList<int>> Subsets(int[] nums)
        //{
        //    var result = new List<IList<int>>();

        //    foreach (var elt in nums)
        //    {
        //        if (result.Any())
        //        {
        //            var temporaryCombinations = new List<IList<int>>();

        //            foreach (var element in result)
        //            {
        //                var tempResult = new List<int>();
        //                tempResult.AddRange(element.ToArray());
        //                tempResult.Add(elt);
        //                temporaryCombinations.Add(tempResult);
        //            }

        //            result.AddRange(temporaryCombinations);
        //        }

        //        result.Add(new[] { elt });
        //    }

        //    result.Add(Enumerable.Empty<int>().ToArray());
        //    return result;
        //}

        // Actual Solution - Backtracking Approach
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            this.BackTrack(nums, new List<int>(), result, 0, nums.Length);
            return result;
        }

        private void BackTrack(int[] nums, List<int> tempResult, List<IList<int>> result, int startIndex, int end)
        {
            if (tempResult.Count > end)
            {
                return;
            }

            result.Add(tempResult.ToArray());

            for (var i = startIndex; i < end; i++)
            {
                tempResult.Add(nums[i]);
                this.BackTrack(nums, tempResult, result, i + 1, end);
                tempResult.RemoveAt(tempResult.Count - 1);
            }
        }
    }
}

