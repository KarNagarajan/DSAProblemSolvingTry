using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class SortedArrayToBinarySearchTree
    {
        internal TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            return ToBinarySearchTree(nums, 0, nums.Length - 1);
        }

        private TreeNode ToBinarySearchTree(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return null;
            }

            var midPoint = leftIndex + ((rightIndex - leftIndex) / 2);
            var node = new TreeNode(nums[midPoint])
                           {
                               left = ToBinarySearchTree(nums, leftIndex, midPoint - 1),
                               right = ToBinarySearchTree(nums, midPoint + 1, rightIndex)
                           };
            return node;
        }
    }
}