
namespace HandsOnTry.Easy
{
    internal class SquareRootOfNumber
    {
        public int MySqrt(int x)
        {
            if (x < 2)
            {
                return x;
            }

            var left = 1;
            var right = x;

            var input = (long) x;

            while (left < right)
            {
                long mid = left + ((right - left) / 2);

                if (mid * mid == input)
                {
                    return (int) mid;
                }

                if (mid * mid < x)
                {
                    left = (int) mid + 1;
                }

                if (mid * mid > x)
                {
                    right = (int) mid;
                }
            }

            return left - 1;
        }
    }
}