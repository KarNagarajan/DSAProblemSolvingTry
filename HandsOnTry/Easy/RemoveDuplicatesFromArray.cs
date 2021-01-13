
namespace HandsOnTry.Easy
{
    internal class RemoveDuplicatesFromArray
    {
        internal int RemoveDuplicates(int[] nums)
        {
            // [1,1,2]
            if (nums.Length == 0)
            {
                return 0;
            }

            var i = 0;
            for (var j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
