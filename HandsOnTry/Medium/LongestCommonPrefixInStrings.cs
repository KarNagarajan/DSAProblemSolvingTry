using System;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class LongestCommonPrefixInStrings
    {
        internal string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

            var index = 0;
            var length = strs[0].Length;
            var lengthyPrefix = string.Empty;

            if (length > 0)
            {
                var character = strs[0][index];

                while (index < length)
                {
                    if (strs.Any(str => character != str[index]))
                    {
                        return lengthyPrefix;
                    }

                    lengthyPrefix = $"{ lengthyPrefix }{ character }";
                    index++;
                    if (index < length)
                    {
                        character = strs[0][index];
                    }
                }
            }

            return lengthyPrefix;
        }
    }
}
