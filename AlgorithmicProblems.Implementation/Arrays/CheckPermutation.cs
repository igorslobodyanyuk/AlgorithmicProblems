using System.Collections.Generic;
using System.Text;

namespace AlgorithmicProblems.Implementation.Strings
{
    /// <summary>
    /// 1.2 Decide if one string is permutation of other
    /// </summary>
    public static class CheckPermutation
    {
        public static bool Check(string source, string target)
        {
            if (source.Length != target.Length)
                return false;

            int n = source.Length;
            var letterCounts = new Dictionary<char, int>();
            for (var i = 0; i < source.Length; i++)
            {
                var c = target[i];
                if (!letterCounts.TryAdd(c, 1))
                {
                    letterCounts[c]++;
                }
            }

            foreach (var c in source)
            {
                if (letterCounts.TryGetValue(c, out var count))
                {
                    letterCounts[c] = --count;
                    if (count == 0)
                        letterCounts.Remove(c);
                }
                else
                    return false;
            }

            return true;
        }
    }
}