using System.Collections.Generic;
using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Easy
{
    internal class IsStackValidPalindrome
    {
        internal bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }

            var elements = new List<int> { head.val };
            while (head.next != null)
            {
                elements.Add(head.next.val);
                head = head.next;
            }

            var length = elements.Count;
            for (var k = 0; k < elements.Count / 2; k++)
            {
                if (elements[k] != elements[length - 1])
                {
                    return false;
                }

                length--;
            }

            return true;
        }
    }
}