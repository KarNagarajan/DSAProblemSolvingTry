using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.Medium
{
    internal class LeastPerfectSquaresWithinNumber
    {
        private List<int> dp = new List<int>();

        public int NumSquares(int n)
        {
            var i = 0;
            while (i <= n)
            {
                this.dp.Add(-1);
                i++;
            }

            return this.GetMinPerfectSquare(n);
        }

        private int GetMinPerfectSquare(int n)
        {
            if (this.dp[n] != -1)
            {
                return this.dp[n];
            }

            if (n == 0)
            {
                return n;
            }

            var min = int.MaxValue;

            for (var i = 1; i * i <= n; i++)
            {
                var currentMin = this.GetMinPerfectSquare(n - i * i) + 1;
                min = Math.Min(min, currentMin);
            }

            this.dp[n] = min;
            return min;
        }
    }
}
