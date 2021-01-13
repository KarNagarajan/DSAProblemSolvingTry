
namespace HandsOnTry.Easy
{
    internal class CountOfMatchesInTournament
    {
        public int NumberOfMatches(int n)
        {
            if (n < 2)
            {
                return 0;
            }

            if (n % 2 == 0)
            {
                return n / 2 + this.NumberOfMatches(n / 2);
            }

            return (n-1) / 2 + this.NumberOfMatches(((n - 1) / 2) + 1);
        }
    }
}
