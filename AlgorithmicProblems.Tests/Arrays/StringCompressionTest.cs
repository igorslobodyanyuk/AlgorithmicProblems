using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class StringCompressionTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("aaaaa", "a5")]
        [InlineData("abbcccdddee", "a1b2c3d3e2")]
        [InlineData("BbB", "b3")]
        [InlineData("abbb", "abbb")]
        [InlineData("aaa111122", "a31422")]
        public void TestStringCompression(string input, string result)
        {
            Assert.Equal(result, StringCompression.Execute(input));
        }
    }
}