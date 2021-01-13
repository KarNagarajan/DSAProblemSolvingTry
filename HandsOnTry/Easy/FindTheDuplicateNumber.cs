using System.Collections.Generic;

namespace HandsOnTry.Easy
{
    internal class FindTheDuplicateNumber
    {
        internal int FindDuplicate(int[] nums)
        {
            var numsDuplicate = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!numsDuplicate.ContainsKey(num))
                {
                    numsDuplicate.Add(num, 1);
                }
                else
                {
                    return num;
                }
            }

            return 0;
        }
    }
}
