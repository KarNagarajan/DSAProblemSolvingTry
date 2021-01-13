
namespace HandsOnTry.Easy
{
    internal class BuySellOnceMaxProfit
    {
        internal int MaxProfit(int[] prices)
        {
            if (prices.Length == 1 || prices.Length == 0)
            {
                return 0;
            }

            if (prices.Length == 2)
            {
                if (prices[1] - prices[0] > 0)
                {
                    return prices[1] - prices[0];
                }

                return 0;
            }

            var minValue = prices[0];
            var maxProfit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                    continue;
                }

                maxProfit = prices[i] - minValue > maxProfit ? prices[i] - minValue : maxProfit;
            }

            return maxProfit;
        }
    }
}