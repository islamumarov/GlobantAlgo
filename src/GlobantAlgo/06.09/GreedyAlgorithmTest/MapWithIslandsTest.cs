using GreedyAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GreedyAlgorithmTest
{
    public class MapWithIslandsTest
    {
        [Fact]
        public void FindAreaTest()
        {
            var map = new MapWithIslands();
            var matrix1 = new int[,] { {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},{0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},{0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},{0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}  };
            var expected = 6;
           // var actual1 = MapWithIslands.countIslands(matrix1);
            var actual2 = map.MaxAreaOfIsland(matrix1);
            Assert.Equal<int>(expected, actual2);
        }

    }
}
