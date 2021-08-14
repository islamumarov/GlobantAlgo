using PredictWinnerName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PairGameWinnerName
{
    public class PredictWinnerTest
    {
        [Theory]
        [InlineData(new int[] { 1, 5, 2 }, false)]
        [InlineData(new int[] { 1, 5, 233, 7 }, true)]
        public void PredictTheWinnerTest(int[] data, bool expected)
        {
            var actual = PairGameWinner.PredictTheWinner(data);
            Assert.Equal(expected, actual);
        }
    }
}
