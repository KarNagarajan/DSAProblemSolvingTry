using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class IsSymmetricBinaryTree
    {
        internal bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSame(root.left, root.right);
        }

        private bool IsSame(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return IsSame(left.right, right.left) && IsSame(left.left, right.right);
        }
    }
}
