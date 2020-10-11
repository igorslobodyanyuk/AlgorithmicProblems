using AlgorithmicProblems.Implementation.Strings;
using Xunit;

namespace AlgorithmicProblems.Tests.Strings
{
    public class UrlifyTest
    {
        [Theory]
        [InlineData("", 0, "")]
        [InlineData("abcd", 4, "abcd")]
        [InlineData("a b  c", 12, "a%20b%20%20c")]
        [InlineData("ab d  cd ", 17, "ab%20d%20%20cd%20")]
        [InlineData("   ", 9, "%20%20%20")]
        public void TestUrlify(string sourceStr, int length, string expected)
        {
            var charArray = new char[length];
            for (int i = 0; i < sourceStr.Length; i++)
            {
                charArray[i] = sourceStr[i];
            }
            
            Urlify.Execute(charArray, length);
            
            Assert.Equal(expected, new string(charArray));
        }
    }
}