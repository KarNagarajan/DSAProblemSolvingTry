
namespace HandsOnTry.Medium
{
    internal class NumberOfIslandsCountBFS
    {
        internal int NumIslands(char[][] grid)
        {
            var count = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        this.SwapIslandToWater(grid, i, j);
                    }
                }
            }

            return count;
        }

        private void SwapIslandToWater(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';

            this.SwapIslandToWater(grid, i + 1, j);
            this.SwapIslandToWater(grid, i - 1, j);
            this.SwapIslandToWater(grid, i, j + 1);
            this.SwapIslandToWater(grid, i, j - 1);
        }
    }
}
