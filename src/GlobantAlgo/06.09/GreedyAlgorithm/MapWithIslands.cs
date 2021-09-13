using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    public class MapWithIslands
    {


        /// <summary>
//        You are given an m x n binary matrix grid.An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.
        /// The area of an island is the number of cells with a value 1 in the island.
        /// Return the maximum area of an island in grid.If there is no island, return 0
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int MaxAreaOfIsland(int[][] grid){
            int maxArea = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int area = 0;
                        area = GetArea(grid, i, j);
                        if (area > maxArea)
                        {
                            maxArea = area;
                        }
                    }
                }
            }
            return maxArea;
        }

        private int GetArea(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0)
            {
                return 0;
            }
            grid[i][j] = 0;
            return 1 + GetArea(grid, i + 1, j) + GetArea(grid, i - 1, j) + GetArea(grid, i, j + 1) + GetArea(grid, i, j - 1);
        }

        

        public int MaxAreaOfIsland(int[,] grid)
        {
            int maxArea = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        maxArea = Math.Max(maxArea, AreaOfIsland(grid, i, j));
                    }
                }
            }
            return maxArea;
        }

        private int AreaOfIsland(int[,] grid, int i, int j)
        {
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i, j] == 0)
            {
                return 0;
            }
            grid[i, j] = 0;
            return 1 + AreaOfIsland(grid, i + 1, j) + AreaOfIsland(grid, i - 1, j) + AreaOfIsland(grid, i, j + 1) + AreaOfIsland(grid, i, j - 1);
        }
    }
}
