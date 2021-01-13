
namespace HandsOnTry.Medium
{
    internal class ProductOfArrayExceptSelf
    {
        internal int[] ProductExceptSelf(int[] nums)
        {
            var n = nums.Length;

            var left = new int[n];
            var right = new int[n];
            var output = new int[n];

            left[0] = 1;
            right[n - 1] = 1;

            for (var j = 1; j < n; j++)
            {
                left[j] = nums[j - 1] * left[j - 1];
            }

            for (var k = n - 2; k >= 0; k--)
            {
                right[k] = nums[k + 1] * right[k + 1];
            }

            for (var i = 0; i < n; i++)
            {
                output[i] = left[i] * right[i];
            }

            return output;
        }
    }
}
