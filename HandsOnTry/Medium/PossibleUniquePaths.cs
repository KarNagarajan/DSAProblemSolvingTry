using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.Medium
{
    internal class PossibleUniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            var possiblePaths = new int[m, n];

            for (var i = 0; i < n; i++)
            {
                possiblePaths[0, i] = 1;
            }

            for (var i = 0; i < m; i++)
            {
                possiblePaths[i, 0] = 1;
            }

            for (var i = 1; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    possiblePaths[i, j] = possiblePaths[i - 1, j] + possiblePaths[i, j - 1];
                }
            }

            return possiblePaths[m - 1, n - 1];
        }
    }
}
