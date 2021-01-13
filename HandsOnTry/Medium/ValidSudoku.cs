using System.Collections.Generic;
using System.Linq;

namespace HandsOnTry.Medium
{
    internal class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            foreach (var t in board)
            {
                if (!this.IsValidConfiguration(t))
                {
                    return false;
                }
            }

            var w = 0;
            while (w < board.Length)
            {
                var listOfElements = new List<char>();

                foreach (var t in board)
                {
                    listOfElements.Add(t[w]);
                }

                if (!this.IsValidConfiguration(listOfElements.ToArray()))
                {
                    return false;
                }

                w++;
            }

            var listOfElementsInnerMatrix = new List<char>();

            var startIndex = 0;
            var endIndex = 3;
            var columnIndex = 0;

            while (startIndex < endIndex)
            {
                var rowIndex = 0;

                while (rowIndex < board.Length)
                {
                    for (var i = columnIndex; i < columnIndex + 3; i++)
                    {
                        listOfElementsInnerMatrix.Add(board[rowIndex][i]);
                    }

                    if (listOfElementsInnerMatrix.Count % 9 == 0)
                    {
                        if (!this.IsValidConfiguration(listOfElementsInnerMatrix.ToArray()))
                        {
                            return false;
                        }

                        listOfElementsInnerMatrix.Clear();
                    }

                    rowIndex++;
                }

                startIndex++;
                columnIndex = columnIndex + 3;
            }

            return true;
        }

        private bool IsValidConfiguration(char[] elements)
        {
            var filteredElements = elements.Where(elt => elt != '.').ToArray();
            return filteredElements.Distinct().Count() == filteredElements.Count();
        }
    }
}
