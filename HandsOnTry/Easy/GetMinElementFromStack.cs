using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Easy
{
    internal class GetMinElementFromStack
    {
        private Stack<int> items = null;

        private List<int> sortedList = null;

        public GetMinElementFromStack()
        {
            this.items = new Stack<int>();
            this.sortedList = new List<int>();
        }

        public void Push(int x)
        {
            this.items.Push(x);
            this.sortedList.Add(x);
            this.sortedList.Sort();
        }

        public void Pop()
        {
            var returnedItem = this.items.Pop();
            this.sortedList.Remove(returnedItem);
            this.sortedList.Sort();
        }

        public int Top()
        {
            return this.items.Peek();
        }

        public int GetMin()
        {
            return this.sortedList.First();
        }
    }
}
