using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class OneAwayTest
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("abc", "abc", true)]
        [InlineData("abc", "ab", true)]
        [InlineData("abc", "aabc", true)]
        [InlineData("abc", "adc", true)]
        [InlineData("TestString", "TestSting", true)]
        [InlineData("abcde", "abc", false)]
        [InlineData("abcd", "abe", false)]
        [InlineData("ABC", "abc", false)]
        public void TestOneAway(string first, string second, bool expected)
        {
            Assert.Equal(expected, OneAway.Execute(first, second));
        }
    }
}