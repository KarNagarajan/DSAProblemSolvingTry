using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class IsValidSymbolsOpeningClosingProper
    {
        internal bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }

            if (s.Length % 2 != 0)
            {
                return false;
            }

            var symbolsDictionary = new Dictionary<char, char> { { '(', ')' }, { '[', ']' }, { '{', '}' } };
            var symbolsStack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (!symbolsDictionary.ContainsKey(s[i]))
                {
                    if (!symbolsStack.Any() || symbolsStack.Pop() != s[i])
                    {
                        return false;
                    }

                    continue;
                }

                if (i + 1 < s.Length && s[i + 1] == symbolsDictionary[s[i]])
                {
                    i++;
                    continue;
                }

                symbolsStack.Push(symbolsDictionary[s[i]]);
            }

            return !symbolsStack.Any();
        }
    }
}