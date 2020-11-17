using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class IsRotationTest
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("abc", "ab", false)]
        [InlineData("abc", "cab", true)]
        [InlineData("waterbottle", "erbottlewat", true)]
        public void TestIsRotation(string source, string target, bool result)
        {
            Assert.Equal(result, StringRotation.IsRotation(source, target));
        }
    }
}