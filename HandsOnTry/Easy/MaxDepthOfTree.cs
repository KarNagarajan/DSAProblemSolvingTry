using System;
using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class MaxDepthOfTree
    {
        internal int MaxDepth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftChildren = MaxDepth(node.left) + 1;
            var rightChildren = MaxDepth(node.right) + 1;
            return Math.Max(leftChildren, rightChildren);
        }
    }
}
