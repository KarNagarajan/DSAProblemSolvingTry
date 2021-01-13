using System;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class ShuffleAnArray
    {
        private int[] internalNums = null;

        public ShuffleAnArray(int[] nums)
        {
            this.internalNums = nums;
        }

        public int[] Reset()
        {
            return this.internalNums;
        }

        // Fisher Yates Shuffle/ Knuth Shuffle
        public int[] Shuffle()
        {
            var tempArray = this.internalNums.ToArray();

            var length = tempArray.Length;
            var randomNumber = new Random();

            for (var k = 0; k < length; k++)
            {
                var index = randomNumber.Next(k, length);

                var temp = tempArray[k];
                tempArray[k] = tempArray[index];
                tempArray[index] = temp;
            }

            return tempArray;
        }
    }
}
