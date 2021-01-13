using System;

namespace HandsOnTry.Easy
{
    internal class IsNumberAPowerOfThree
    {
        internal bool IsPowerOfThree(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            var valueOfN = Convert.ToDouble(n);
            while (valueOfN >= 1)
            {
                if (valueOfN == 1)
                {
                    return true;
                }

                valueOfN = valueOfN / 3;
            }

            return false;
        }
    }
}
