using System.Collections.Generic;
using HandsOnTry.HelpersAndExtensions;

namespace HandsOnTry.Medium
{
    internal class NestedIteratorImplementation
    {
        private IList<int> flattenList = new List<int>();

        private int index = -1;

        public NestedIteratorImplementation(IList<NestedInteger> nestedList)
        {
            this.flattenList = this.FlattenList(nestedList);
        }

        public bool HasNext()
        {
            return this.index + 1 < this.flattenList.Count;
        }

        public int Next()
        {
            this.index++;
            return this.flattenList[this.index];
        }

        private IList<int> FlattenList(IList<NestedInteger> nestedList)
        {
            var flattenedList = new List<int>();

            foreach (var nestedInteger in nestedList)
            {
                if (nestedInteger.IsInteger())
                {
                    flattenedList.Add(nestedInteger.GetInteger());
                }
                else
                {
                    flattenedList.AddRange(this.FlattenList(nestedInteger.GetList()));
                }
            }

            return flattenedList;
        }
    }
}