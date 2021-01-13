using System.Collections.Generic;

namespace HandsOnTry.Medium
{
    internal class GroupAnagramArrayElements
    {
        internal IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var output = new List<IList<string>>();

            if (strs.Length == 0)
            {
                return output;
            }

            if (strs.Length == 1)
            {
                output.Add(new[] { strs[0] });
                return output;
            }

            var areValidAnagrams = new bool[strs.Length];
            var anagramDict = new Dictionary<string, List<string>>();
            
            for (var k = 0; k < strs.Length; k++)
            {
                if (!areValidAnagrams[k])
                {
                    if (!anagramDict.ContainsKey(strs[k]))
                    {
                        anagramDict.Add(strs[k], new List<string>());
                    }

                    for (var j = k + 1; j < strs.Length; j++)
                    {
                        if (this.IsAnagram(strs[k], strs[j]))
                        {
                            anagramDict[strs[k]].Add(strs[j]);
                            areValidAnagrams[j] = true;
                        }
                    }
                }
            }

            foreach (var anagram in anagramDict)
            {
                var tempResult = new List<string> { anagram.Key };
                tempResult.AddRange(anagram.Value);
                output.Add(tempResult);
            }

            return output;

            // Actual Solution - Loop array once only. For each element sort it and see if its part of dict or else add it
            // By doing this, first elt will be aer and key will be aer. When next element is rea while sorting it will become 
            // aer and it will be in dict and hence just add in value. Here though complexity is in sorting, we end up in looping
            // only once
        }

        private bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var table = new int[26];

            foreach (var character in s)
            {
                table[character - 'a']++;
            }

            foreach (var character in t)
            {
                table[character - 'a']--;
                if (table[character - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
