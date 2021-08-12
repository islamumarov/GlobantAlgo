using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLinesOfString;
using Xunit;

namespace ThreeLinesOfStringTest
{
    public class MergeLinesTest
    {

        [Theory]
        [InlineData("aabcc","dbbca","aadbbbaccc", false)]
        [InlineData("aabcc","dbbca","aadbbcbcac", true)]
        public void CheckLines(string firstLine, string secondLine, string thirdLine, bool expected)
        {
            var actual = MergeLines.IsInterleave(firstLine, secondLine, thirdLine);
            Assert.Equal(expected, actual);
        }

    }
}
