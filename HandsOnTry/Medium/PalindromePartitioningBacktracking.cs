using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class PalindromePartitioningBacktracking
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<String>> result = new List<IList<String>>();

            this.FindPalindromes(0, result, new List<String>(), s);

            return result;
        }

        private void FindPalindromes(int start, List<IList<string>> result, List<string> currentList, string s)
        {
            if (start >= s.Length)
            {
                result.Add(new List<string>(currentList));
            }

            for (int end = start; end < s.Length; end++)
            {
                if (this.IsPalindrome(s, start, end))
                {
                    currentList.Add(s.Substring(start, (end - start) + 1));
                    this.FindPalindromes(end + 1, result, currentList, s);
                    currentList.Remove(currentList.Last());
                }
            }
        }

        private bool IsPalindrome(string s, int low, int high)
        {
            while (low < high)
            {
                if (s[low++] != s[high--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
