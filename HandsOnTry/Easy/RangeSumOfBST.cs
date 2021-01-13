using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }

            var sum = 0;

            if (root.val >= low && root.val <= high)
            {
                sum = root.val;
            }

            sum += this.RangeSumBST(root.left, low, high);
            sum += this.RangeSumBST(root.right, low, high);

            return sum;
        }
    }
}
