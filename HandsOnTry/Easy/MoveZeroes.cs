
namespace HandsOnTry.Easy
{
    internal class MoveZeroes
    {
        internal void ExecuteMoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 1)
            {
                return;
            }

            var i = 0;
            var k = 0;

            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    if (nums[k] == 0)
                    {
                        nums[k] = nums[i];
                        nums[i] = 0;
                    }

                    k++;
                }

                i++;
            }
        }
    }
}