using System.Collections.Generic;

namespace HandsOnTry.Easy
{
    internal class FizzBuzz
    {
        internal IList<string> PrintFizzBuzz(int n)
        {
            if (n == 0)
            {
                return new[] { "0" };
            }

            var listOfString = new List<string>();
            int k = 1;

            while (k <= n)
            {
                if (k % 3 == 0)
                {
                    listOfString.Add(k % 5 == 0 ? "FizzBuzz" : "Fizz");
                }
                else if (k % 5 == 0)
                {
                    listOfString.Add("Buzz");
                }
                else
                {
                    listOfString.Add(k.ToString());
                }

                k++;
            }

            return listOfString;
        }
    }
}