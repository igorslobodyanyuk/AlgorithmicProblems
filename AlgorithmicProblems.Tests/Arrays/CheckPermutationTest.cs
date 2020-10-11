using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class CheckPermutationTest
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("abcd", "", false)]
        [InlineData("", "abcd", false)]
        [InlineData("abcd", "bcad", true)]
        [InlineData("abcdabcdd", "dddccbbaa", true)]
        [InlineData("aaaa", "aaab", false)]
        public void TestPermutationsCheck(string source, string target, bool result)
        {
            Assert.Equal(result, CheckPermutation.Check(source, target));
        }
    }
}