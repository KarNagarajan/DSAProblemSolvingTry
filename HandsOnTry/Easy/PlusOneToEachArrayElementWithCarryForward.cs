using System.Collections.Generic;

namespace HandsOnTry.Easy
{
    internal class PlusOneToEachArrayElementWithCarryForward
    {
        internal int[] PlusOne(int[] digits)
        {
            var i = digits.Length;
            var result = new Stack<int>();
            var carryForward = 0;

            while (i > 0)
            {
                var element = digits[i - 1];

                if (i == digits.Length)
                {
                    if (element == 9)
                    {
                        result.Push(0);
                        carryForward = 1;
                    }
                    else
                    {
                        result.Push(element + 1);
                    }

                    i--;
                    continue;
                }

                if (carryForward > 0)
                {
                    if (element == 9)
                    {
                        result.Push(0);
                        carryForward = 1;
                    }
                    else
                    {
                        result.Push(element + carryForward);
                        carryForward = 0;
                    }
                }
                else
                {
                    result.Push(element);
                    carryForward = 0;
                }

                i--;
            }

            if (carryForward > 0)
            {
                result.Push(carryForward);
            }

            var responseLength = result.Count;
            var response = new int[responseLength];
            for (var j = 0; j < responseLength; j++)
            {
                response[j] = result.Pop();
            }

            return response;
        }
    }
}