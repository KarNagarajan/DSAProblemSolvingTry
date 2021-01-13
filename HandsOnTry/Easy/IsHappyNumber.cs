using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.Easy
{
    internal class IsHappyNumber
    {
        List<int> numbers = new List<int>();

        internal bool IsHappy(int n)
        {
            if (n == 0)
            {
                return false;
            }

            var no = n.ToString();
            var sum = 0;
            var length = no.Length;
            while (length > 0)
            {
                var number = int.Parse(no[length - 1].ToString());
                sum = sum + number * number;
                length--;
            }

            if (sum == 1)
            {
                return true;
            }

            if (!numbers.Contains(sum))
            {
                numbers.Add(sum);
                return IsHappy(sum);
            }

            return false;
        }
    }
}
