using System.Collections.Generic;

namespace HandsOnTry.Medium
{
    internal class GeneratePossibleParanthesisBacktracking
    {
        internal IList<string> GenerateParenthesis(int n)
        {
            var output = new List<string>();
            this.Backtrack(output, string.Empty, 0, 0, n);
            return output;
        }

        private void Backtrack(List<string> output, string currentParanthesis, int open, int close, int max)
        {
            if (currentParanthesis.Length == max * 2)
            {
                output.Add(currentParanthesis);
                return;
            }

            if (open < max)
            {
                this.Backtrack(output, currentParanthesis + "(", open + 1, close, max);
            }

            if (close < open)
            {
                this.Backtrack(output, currentParanthesis + ")", open, close + 1, max);
            }
        }
    }
}
