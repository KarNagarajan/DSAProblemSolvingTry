using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class ReverseLinkedList
    {
        internal ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var previousElement = head;
            var nextElement = head.next;
            previousElement.next = null;

            while (nextElement != null)
            {
                head = nextElement;
                nextElement = nextElement.next;
                head.next = previousElement;
                previousElement = head;
            }

            return head;
        }
    }
}