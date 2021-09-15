using Combinatorics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CombinatoricsTest
{
    public class UniquePathsTest
    {


        [Theory]
        [InlineData(3,7,28)]
        [InlineData(10,10, 48620)]
        public void UniquePaths(int m, int n, int expected)
        {
            var actual = UniquePath.UniquePaths(m, n);
            Assert.Equal(expected, actual);
        }
    }
}
