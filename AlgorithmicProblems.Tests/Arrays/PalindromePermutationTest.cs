using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class PalindromePermutationTest
    {
        [Theory]
        [InlineData("", true)]
        [InlineData(" 123 ", true)]
        [InlineData("Taco coa", true)]
        [InlineData("AaAaA", true)]
        [InlineData("aaaa", true)]
        [InlineData(" bb  bb bb ", true)]
        [InlineData("hheella", true)]
        [InlineData("abc", false)]
        [InlineData("Tree", false)]
        public void TestPalindromePermutations(string source, bool isPalindrome)
        {
            Assert.Equal(isPalindrome, PalindromePermutation.Execute(source));
        }
    }
}