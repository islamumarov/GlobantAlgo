using BracketsValidator;
using Xunit;

namespace Tests
{
    public class ValidateBracketsTest
    {

        [Theory]
        [InlineData("{[()]}", true)]
        [InlineData("{[(])}", false)]
        public void BracketsLineIsValidTest(string bracketsLine, bool expect)
        {
            var validate = new ValidateBrackets();
            var actual = validate.IsBracketsValid(bracketsLine);

            Assert.Equal(expect, actual);

        }

    }
}
