using System.Text;

namespace AlgorithmicProblems.Implementation.Arrays
{
    // 1.6 String Compression: implement a method to perform a basic string compression using the counts of repeated characters.
    // Example: aabcccccaaa would become a2b1c5a3
    // If the compressed string is not smaller than the original, return original
    public static class StringCompression
    {
        public static string Execute(string input)
        {
            char lastSymbol = default;
            int sequenceCount = 0;
            var result = new StringBuilder();

            foreach (var current in input.ToLower())
            {
                if (current == lastSymbol)
                {
                    sequenceCount++;
                }
                else
                {
                    if (sequenceCount > 0)
                        result.Append($"{lastSymbol}{sequenceCount}");
                    
                    lastSymbol = current;
                    sequenceCount = 1;
                }
            }

            result.Append($"{lastSymbol}{sequenceCount}");

            return result.Length < input.Length ? result.ToString() : input;
        }
    }
}