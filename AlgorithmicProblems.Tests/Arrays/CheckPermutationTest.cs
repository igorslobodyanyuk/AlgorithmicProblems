using AlgorithmicProblems.Implementation.Strings;
using Xunit;

namespace AlgorithmicProblems.Tests.Strings
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