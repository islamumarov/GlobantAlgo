using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectWithTests
{
    public class ReverseDataTest
    {

        [Theory]
        [InlineData("ab", "ab")]
        [InlineData("(ab)", "ba")]
        [InlineData("((ab))", "ab")]
        [InlineData("(a(bc)d)","dbca")]
        public void ReverseSubString(string line, string expected)
        {
            var reveser = new GFG();
            var actual = reveser.reverseParentheses(line, line.Length);

            Assert.Equal(expected,actual);
        }   
    }
}
