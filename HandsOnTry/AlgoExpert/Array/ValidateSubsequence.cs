using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTry.AlgoExpert.Array
{
    internal class ValidateSubsequence
    {
        internal bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            var arrayPointer = 0;
            var sequencePointer = 0;

            while (arrayPointer < array.Count && sequencePointer != sequence.Count)
            {
                if (array[arrayPointer] == sequence[sequencePointer])
                {
                    arrayPointer++;
                    sequencePointer++;
                }
                else
                {
                    arrayPointer++;
                }
            }

            return sequencePointer == sequence.Count;
        }
	}
}
