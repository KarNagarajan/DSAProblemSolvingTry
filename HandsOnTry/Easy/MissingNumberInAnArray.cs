
namespace HandsOnTry.Easy
{
    internal class MissingNumberInAnArray
    {
        internal int MissingNumber(int[] nums)
        {
            var length = nums.Length;

            var k = 0;
            var expectedSum = 0;
            var actualSum = 0;

            while (k < length)
            {
                expectedSum = expectedSum + k + 1;
                actualSum += nums[k];
                k++;
            }

            return expectedSum - actualSum;
        }
    }
}
