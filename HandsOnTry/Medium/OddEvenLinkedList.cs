using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Medium
{
    internal class OddEvenLinkedList
    {
        internal ListNode OddEvenList(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var oddPtr = head;
            var evenPtr = head.next;

            var evenRefPtr = head.next;

            while (oddPtr?.next?.next != null || evenPtr?.next?.next != null)
            {
                if (oddPtr?.next != null)
                {
                    oddPtr.next = oddPtr.next.next;
                    oddPtr = oddPtr.next;
                }

                if (evenPtr?.next != null)
                {
                    evenPtr.next = oddPtr.next;
                    evenPtr = evenPtr.next;
                }
            }

            oddPtr.next = evenRefPtr;
            return head;
        }
    }
}