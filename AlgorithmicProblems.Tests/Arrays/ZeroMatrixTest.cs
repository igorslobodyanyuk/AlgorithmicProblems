using System;
using System.Linq;
using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class ZeroMatrixTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("1", "1")]
        [InlineData("1 2 3;4 5 6;7 8 9", "1 2 3;4 5 6;7 8 9")]
        [InlineData("1 2 3;4 0 6;7 8 9", "1 0 3;" +
                                         "0 0 0;" +
                                         "7 0 9")]
        [InlineData("0 2 3;4 5 6;0 8 9", "0 0 0;" +
                                         "0 5 6;" +
                                         "0 0 0")]
        public void Test(string source, string target)
        {
            Assert.Equal(StringToMatrix(target), ZeroMatrix.Execute(StringToMatrix(source)));
        }

        private static int[][] StringToMatrix(string sourceString)
        {
            if (string.IsNullOrEmpty(sourceString))
                return Array.Empty<int[]>();
                
            return sourceString.Split(';').Select(s => s.Split(' ').Select(int.Parse).ToArray()).ToArray();
        }
    }
}