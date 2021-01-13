
namespace HandsOnTry.Easy
{
    internal class FindMaxWealthCustomer
    {
        internal int MaximumWealth(int[][] accounts)
        {
            var max = 0;

            foreach (var account in accounts)
            {
                var tempSum = 0;

                foreach (var wealth in account)
                {
                    tempSum += wealth;
                }

                if (tempSum > max)
                {
                    max = tempSum;
                }
            }

            return max;
        }
    }
}
