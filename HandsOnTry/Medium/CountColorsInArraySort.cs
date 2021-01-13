
namespace HandsOnTry.Medium
{
    internal class CountColorsInArraySort
    {
        public void SortColors(int[] nums)
        {
            if (nums.Length == 1)
            {
                return;
            }

            var index = 0;
            var startIndex = 0;
            var endIndex = nums.Length - 1;

            while (index <= endIndex && startIndex < endIndex)
            {
                if (nums[index] == 0)
                {
                    nums[index] = nums[startIndex];
                    nums[startIndex] = 0;
                    startIndex++;
                    index++;
                }
                else if (nums[index] == 2)
                {
                    nums[index] = nums[endIndex];
                    nums[endIndex] = 2;
                    endIndex--;
                }
                else
                {
                    index++;
                }
            }
        }
    }
}
