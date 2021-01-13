
namespace HandsOnTry.Medium
{
    internal class MaxProfitForMultipleSell
    {
        // Peak - Valley Approach
        internal int CalculateMaxProfitForMultipleSell(int[] prices)
        {
            var maxprofit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxprofit += prices[i] - prices[i - 1];
                }
            }

            return maxprofit;
        }

    }
}