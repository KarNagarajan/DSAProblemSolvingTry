using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class GetIntersectionNodeInTwoLinkedLists
    {
        internal ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            var headA_Pointer = headA;
            var headB_Pointer = headB;

            while (headA_Pointer != headB_Pointer)
            {
                headA_Pointer = headA_Pointer == null ? headB : headA_Pointer.next;
                headB_Pointer = headB_Pointer == null ? headA : headB_Pointer.next;
            }

            return headA_Pointer;
        }
    }
}
