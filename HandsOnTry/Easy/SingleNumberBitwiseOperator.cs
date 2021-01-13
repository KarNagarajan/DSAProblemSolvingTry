using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Easy
{
    internal class SingleNumberBitwiseOperator
    {
        internal int SingleNumber(int[] nums)
        {
            // This implementation with dictionary
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var dictionary = new Dictionary<int, int>();
            var i = 0;

            while (i < nums.Length)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                }
                else
                {
                    dictionary[nums[i]] = dictionary[nums[i]] + 1;
                }

                i++;
            }

            var result = dictionary.Single(dict => dict.Value == 1);
            return result.Key;

            // Solution - Use bitwise operator to avoid using dictionary
        }
    }
}