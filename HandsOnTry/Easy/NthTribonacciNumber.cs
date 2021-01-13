
namespace HandsOnTry.Easy
{
    internal class NthTribonacciNumber
    {
        private int[] dp = new int[38];

        internal int Tribonacci(int n)
        {
            this.dp[1] = 1;
            this.dp[2] = 1;
            var tribonacciSum = FindTribonacciSum(n);
            return tribonacciSum;
        }

        private int FindTribonacciSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (this.dp[n] > 0)
            {
                return this.dp[n];
            }

            this.dp[n] = this.FindTribonacciSum(n - 1) + this.FindTribonacciSum(n - 2) + this.FindTribonacciSum(n - 3);
            return this.dp[n];
        }
    }
}
