using System;

namespace HandsOnTry.Easy
{
    internal class ReverseInteger
    {
        internal int Reverse(int x)
        {
            if (x >= -9 && x <= 9)
            {
                return x;
            }

            var result = 0l;

            if (x < int.MinValue + 1)
            {
                return 0;
            }

            var input = (long)Math.Abs(x);

            while (input > 0)
            {
                var tempResult = input % 10;
                input /= 10;
                result = (result * 10) + tempResult;
            }

            if (result > int.MaxValue)
            {
                return 0;
            }

            var output = (int)result;
            return x < 0 ? 0 - output : output;
        }
    }
}
