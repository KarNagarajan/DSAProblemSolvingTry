using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class CycleInLinkedList
    {
        internal bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            var slow = head;
            var fast = head.next;

            while (slow != fast)
            {
                if (fast?.next == null)
                {
                    return false;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
