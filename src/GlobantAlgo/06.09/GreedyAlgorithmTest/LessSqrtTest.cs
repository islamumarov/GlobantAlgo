using GreedyAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GreedyAlgorithmTest
{
    public class LessSqrtTest
    {
        [Theory]
        [InlineData(12,3)]
        [InlineData(13,2)]
        [InlineData(14,3)]
        public void FindSumOfSqrs(int n, int expected)
        {
            var actual = LessSqrt.numSquares(n);

            Assert.Equal(expected, actual);

        }

    }
}
