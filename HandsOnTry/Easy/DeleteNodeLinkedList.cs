using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class DeleteNodeLinkedList
    {
        internal void DeleteNode(ListNode node)
        {
            // My Approach
            //ListNode previousNode = null;

            //while (node.next != null)
            //{
            //    previousNode = node;
            //    node.val = node.next.val;
            //    node = node.next;
            //}

            //previousNode.next = null;

            // Solution Approach
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}