using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.Easy
{
    internal class SubstringInString
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(haystack) || haystack.Length < needle.Length)
            {
                return -1;
            }

            var hayStackPointer = 0;
            var matchedNeedlePointer = -1;

            while (hayStackPointer < haystack.Length)
            {
                if (needle.Length + hayStackPointer <= haystack.Length && haystack.Substring(hayStackPointer, needle.Length) == needle)
                {
                    return hayStackPointer;
                }

                hayStackPointer++;
            }

            return matchedNeedlePointer;
        }
    }
}