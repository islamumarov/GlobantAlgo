using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BracketsValidator;
using Xunit;

namespace ProjectWithTests
{
    public class ValidateBracketsTest
    {
        [Theory]
        [InlineData("{[()]}", true)]
        [InlineData("{[(])}", false)]
        public void BracketsLineIsValidTest(string bracketsLine, bool expect)
        {
            var validate = new ValidateBrackets();
            var actual = validate.IsValidBrackets(bracketsLine);

            Assert.Equal(expect, actual);

        }
    }
}
