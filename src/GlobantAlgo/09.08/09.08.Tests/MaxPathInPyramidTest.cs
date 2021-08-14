using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PyramidAndNodes
{
    public class MaxPathInPyramidTest
    {
        [Fact]
        public void maxPathSumTest()
        {
            var expected = 143;
            int[,] triangle = { { 1, 0, 0, 0 }, { 10, 15, 0, 0 }, { 2, 5, 27, 0 }, { 99, 3, 100, 6 } };
            int actual = Program.maxPathSum(triangle, 3,3);
            Assert.Equal(expected, actual);
        }

    }
}
