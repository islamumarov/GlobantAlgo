using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveEachKthElement;
using Xunit;

namespace DeathOfPrisoners
{
    public class KillPrisonersTest
    {

        // Case 1: When Count of Prisoners more than N
        [Theory]
        [InlineData(8,3,7)]
        [InlineData(8, 20, 8)]
        [InlineData(9000,100000, 12331)]
        public void TestGetLastElement(int k, int n, int expected)
        {
            // Arrange
            // Act
            var list = KillPrisoners.FillList(k);
            var pisoners = new KillPrisoners(list);
            pisoners.RemoveEveryKthPrisoner(n);
            int actual = pisoners.last;
            // Asset
            Assert.Equal(expected, actual);
        }
    }
}
