
namespace HandsOnTry.Medium
{
    internal class CountNumberOfPrimesWithinANumber
    {
        internal int CountPrimes(int n)
        {
            var nums = new bool[n];
            var primeCount = 0;
            var k = 0;

            while (k < n)
            {
                nums[k] = true;
                k++;
            }

            for (var i = 2; i * i < n; i++)
            {
                if (nums[i])
                {
                    for (var j = 2; j * i < n; j++)
                    {
                        nums[j * i] = false;
                    }
                }
            }

            for (var j = 2; j < n; j++)
            {
                if (nums[j])
                {
                    primeCount += 1;
                }
            }

            return primeCount;
        }
    }
}
