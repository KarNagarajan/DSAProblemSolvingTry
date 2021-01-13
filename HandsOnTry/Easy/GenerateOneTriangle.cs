using System.Collections.Generic;

namespace HandsOnTry.Easy
{
    internal class GenerateOneTriangle
    {
        internal IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();

            if (numRows == 0)
            {
                return list;
            }

            var internalList1 = new List<int> { 1 };
            list.Add(internalList1);

            if (numRows == 1)
            {
                return list;
            }

            var internalList2 = new List<int> { 1, 1 };
            list.Add(internalList2);

            if (numRows == 2)
            {
                return list;
            }

            for (var k = 3; k <= numRows; k++)
            {
                var internalList = new List<int> { 1 };

                var j = 1;
                while (j < k - 1)
                {
                    internalList.Add(list[k - 2][j] + list[k - 2][j - 1]);
                    j++;
                }

                internalList.Add(1);
                list.Add(internalList);
            }

            return list;
        }
    }
}