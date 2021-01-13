using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class LetterCombinationPhNumbers
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>();
            }

            var result = new List<string>();

            var numberStringDictionary = new Dictionary<int, string>
                                             {
                                                 { 2, "abc" },
                                                 { 3, "def" },
                                                 { 4, "ghi" },
                                                 { 5, "jkl" },
                                                 { 6, "mno" },
                                                 { 7, "pqrs" },
                                                 { 8, "tuv" },
                                                 { 9, "wxyz" }
                                             };

            var i = 0;

            while (i < digits.Length)
            {
                var str = numberStringDictionary[int.Parse(digits[i].ToString())];
                result = this.Concatenate(str, result);
                i++;
            }

            return result;
        }

        private List<string> Concatenate(string str, List<string> elementsToAppend)
        {
            var concatenatedList = new List<string>();

            for(var i = 0; i < str.Length; i++)
            {
                if (!elementsToAppend.Any())
                {
                    concatenatedList.Add(str[i].ToString());
                }
                else
                {
                    foreach (var element in elementsToAppend)
                    {
                        concatenatedList.Add(element + str[i]);
                    }
                }
            }

            return concatenatedList;
        }
    }
}
