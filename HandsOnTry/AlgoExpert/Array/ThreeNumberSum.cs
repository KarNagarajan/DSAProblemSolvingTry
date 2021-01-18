using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.AlgoExpert.Array
{
    internal class ThreeNumberSum
    {
        internal List<int[]> FindThreeNumberSum(int[] array, int targetSum)
        {
            var threeSumList = new List<int[]>();

            var inputArray = array.OrderBy(i => i).ToArray();
            for (var i = 0; i < inputArray.Length; i++)
            {
                var requiredTargetSum = targetSum - inputArray[i];
                var twoSumArray = inputArray.Skip(i + 1).ToArray();
                var twoSumList = TwoNumberSum(twoSumArray, requiredTargetSum);
                if (twoSumList.Any())
                {
                    foreach (var item in twoSumList)
                    {
                        threeSumList.Add(new[] { inputArray[i], item[0], item[1] });
                    }
                }
            }

            return threeSumList;
        }

        private static List<int[]> TwoNumberSum(int[] array, int targetSum)
        {
            var leftPointer = 0;
            var rightPointer = array.Length - 1;
            var twoSumList = new List<int[]>();

            while (leftPointer < rightPointer)
            {
                if (array[leftPointer] + array[rightPointer] == targetSum)
                {
                    twoSumList.Add(new[] { array[leftPointer], array[rightPointer] });
                    leftPointer++;
                    rightPointer--;
                }
                else if (array[leftPointer] + array[rightPointer] < targetSum)
                {
                    leftPointer++;
                }
                else if (array[leftPointer] + array[rightPointer] > targetSum)
                {
                    rightPointer--;
                }
            }

            return twoSumList;
        }
	}
}
