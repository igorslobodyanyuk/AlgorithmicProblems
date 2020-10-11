using System.Collections.Generic;

namespace AlgorithmicProblems.Implementation.Arrays
{
    /// <summary>
    /// 1.3 Write a method to replace all spaces in input with '%20' in place.
    /// Assume that you are given enough space in the input string.
    /// </summary>
    public static class Urlify
    {
        public static void Execute(char[] source, int length)
        {
            var buffer = new Queue<char>();
            foreach (var c in source)
            {
                buffer.Enqueue(c);
            }
            
            var toReplace = ' ';
            var replacement = new[] {'%', '2', '0'};
            int i = 0;
            
            while (i < length)
            {
                var current = buffer.Dequeue();
                if (current == toReplace)
                {
                    for (int j = 0; j < replacement.Length; j++)
                    {
                        source[i + j] = replacement[j];
                    }

                    i += replacement.Length;
                }
                else
                {
                    source[i] = current;
                    i++;
                }
            }
        }
    }
}