using System.Collections.Generic;

using HandsOnTry.HelpersAndExtensions;


namespace HandsOnTry.Easy
{
    internal class TwoSumIVBSTTargetSum
    {
        List<int> expectedValueList = new List<int>();

        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }

            if (this.expectedValueList.Contains(root.val))
            {
                return true;
            }

            this.expectedValueList.Add(k - root.val);

            return this.FindTarget(root.left, k) || this.FindTarget(root.right, k);
        }
    }
}
