using System.Collections.Generic;

namespace HandsOnTry.Easy
{
    internal class TwoListsAnagram
    {
        internal bool IsAnagram(string s, string t)
        {
            if (s == null && t == null)
            {
                return true;
            }

            if (s == null && t != null || t == null && s != null || s.Length != t.Length)
            {
                return false;
            }

            var first = new Dictionary<char, int>();
            var second = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (first.ContainsKey(s[i]))
                {
                    first[s[i]] = first[s[i]] + 1;
                }
                else
                {
                    first.Add(s[i], 1);
                }

                if (second.ContainsKey(t[i]))
                {
                    second[t[i]] = second[t[i]] + 1;
                }
                else
                {
                    second.Add(t[i], 1);
                }
            }

            foreach (var i in second)
            {
                if (!first.ContainsKey(i.Key))
                {
                    return false;
                }

                if (first[i.Key] != i.Value)
                {
                    return false;
                }
            }

            return true;

            // Actual Solution - Increment one for first string array and decrement one for second string array and at end all should be zero
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] table = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                table[s[i] - 'a']++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                table[t[i] - 'a']--;
                if (table[t[i] - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}