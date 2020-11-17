namespace AlgorithmicProblems.Implementation.Arrays
{
    // 1.7 Rotate Matrix: given an image represented by an NxN matrix, where each pixel is an int, write a method to rotate the image by 90 degrees.
    // Can you do it in place?
    public static class RotateMatrix
    {
        /// <summary>
        /// Rotates square matrix in place by 90 degrees.
        /// </summary>
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
        /// <returns>Rotated matrix.</returns>
        public static int[][] Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            var last = n - 1;
            // Replace in place. n + 1 in the outer loop to include center elements if length is odd.
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < (n + 1) / 2; j++)
                {
                    var buffer = matrix[i][j];
                    matrix[i][j] = matrix[last - j][i];
                    matrix[last - j][i] = matrix[last - i][last - j];
                    matrix[last - i][last - j] = matrix[j][last - i];
                    matrix[j][last - i] = buffer;
                }
            }

            return matrix;
        }
    }
}