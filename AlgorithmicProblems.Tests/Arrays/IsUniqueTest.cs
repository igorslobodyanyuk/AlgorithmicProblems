using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class IsUniqueTest
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("abcd", true)]
        [InlineData("abcd_!фыв", true)]
        [InlineData("aaa", false)]
        [InlineData("abcddefg", false)]
        public void GetsString_ReturnsUniqueness(string inputString, bool result)
        {
            Assert.Equal(IsUnique.IsUniqueLinear(inputString), result);
        }
    }
}