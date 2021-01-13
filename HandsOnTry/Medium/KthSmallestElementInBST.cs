using System.Collections.Generic;
using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Medium
{
    internal class KthSmallestElementInBST
    {
        internal int KthSmallest(TreeNode root, int k)
        {
            // Our Approach

            var output = new List<int>();
            this.TraverseInOrder(root, output, k, 0);
            return output[k - 1];

            // Better Approach - Iteration Instead Of Recursion
            var stack = new LinkedList<TreeNode>();

            while (true)
            {
                while (root != null)
                {
                    stack.AddLast(root);
                    root = root.left;
                }

                root = stack.Last.Value;
                stack.RemoveLast();

                if (--k == 0)
                {
                    return root.val;
                }

                root = root.right;
            }
        }

        private void TraverseInOrder(TreeNode node, List<int> output, int k, int value)
        {
            if (value > 0)
            {
                return;
            }

            if (node.left != null)
            {
                this.TraverseInOrder(node.left, output, k, value);
            }

            output.Add(node.val);
            if (output.Count == k)
            {
                value = output[k - 1];
            }
            
            if (node.right != null)
            {
                this.TraverseInOrder(node.right, output, k, value);
            }
        }
    }
}
