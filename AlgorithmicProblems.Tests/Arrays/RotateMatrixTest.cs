using System.Collections.Generic;
using System.Linq;
using AlgorithmicProblems.Implementation.Arrays;
using Xunit;

namespace AlgorithmicProblems.Tests.Arrays
{
    public class RotateMatrixTest
    {
        /// <example>
        /// 1 2 3    7 4 1
        /// 4 5 6 -> 8 5 2
        /// 7 8 9    9 6 3
        /// </example>
        /// <example>
        /// 10 11 12 13    22 18 14 10
        /// 14 15 16 17 -> 23 19 15 11
        /// 18 19 20 21    24 20 16 12
        /// 22 23 24 25    25 21 17 13
        /// </example>
        [Theory]
        [InlineData("1 2 3;4 5 6;7 8 9", "7 4 1;8 5 2;9 6 3")]
        [InlineData("10 11 12 13;14 15 16 17;18 19 20 21;22 23 24 25",
            "22 18 14 10;23 19 15 11;24 20 16 12;25 21 17 13")]
        public void TestRotateMatrix(string sourceString, string targetString)
        {
            Assert.Equal(StringToMatrix(targetString), RotateMatrix.Rotate(StringToMatrix(sourceString)));
        }

        private static int[][] StringToMatrix(string sourceString)
        {
            return sourceString.Split(';').Select(s => s.Split(' ').Select(int.Parse).ToArray()).ToArray();
        }
    }
}