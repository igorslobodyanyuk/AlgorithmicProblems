using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicProblems.Implementation.Arrays
{
    // 1.8 Zero Matrix: write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.
    public static class ZeroMatrix
    {
        public static int[][] Execute(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix.First().Length == 0)
                return matrix;

            int n = matrix.Length;
            int m = matrix.First().Length;
            var zeroI = new HashSet<int>();
            var zeroJ = new HashSet<int>();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeroI.Add(i);
                        zeroJ.Add(j);
                    }
                }
            }

            foreach (var i in zeroI)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = 0;
                }
            }

            foreach (var j in zeroJ)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i][j] = 0;
                }
            }

            return matrix;
        }
    }
}