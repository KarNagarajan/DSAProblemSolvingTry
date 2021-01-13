
namespace HandsOnTry.Easy
{
    internal class TrailingZeroesInFactorial
    {
        internal int TrailingZeroes(int n)
        {
            var numberOfFive = 0;

            while (n >= 5)
            {
                numberOfFive = numberOfFive + n / 5;
                n /= 5;
            }

            return numberOfFive;
        }
    }
}
