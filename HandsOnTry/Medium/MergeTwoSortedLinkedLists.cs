using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Medium
{
    internal class MergeTwoSortedLinkedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            var firstListCurrentNode = l1;
            var secondListCurrentNode = l2;
            ListNode responseList = null;
            ListNode headNode = null;

            while (firstListCurrentNode != null && secondListCurrentNode != null)
            {
                if (responseList != null)
                {
                    responseList.next = new ListNode();
                    responseList = responseList.next;
                }
                else
                {
                    var head = new ListNode();
                    headNode = head;
                    responseList = head;
                }

                if (firstListCurrentNode.val < secondListCurrentNode.val)
                {
                    responseList.val = firstListCurrentNode.val;
                    firstListCurrentNode = firstListCurrentNode.next;
                }
                else
                {
                    responseList.val = secondListCurrentNode.val;
                    secondListCurrentNode = secondListCurrentNode.next;
                }
            }

            while (firstListCurrentNode != null)
            {
                responseList.next = new ListNode();
                responseList = responseList.next;
                responseList.val = firstListCurrentNode.val;
                firstListCurrentNode = firstListCurrentNode.next;
            }

            while (secondListCurrentNode != null)
            {
                responseList.next = new ListNode();
                responseList = responseList.next;
                responseList.val = secondListCurrentNode.val;
                secondListCurrentNode = secondListCurrentNode.next;
            }

            return headNode;
        }
    }
}