using System.Collections.Generic;

namespace AlgorithmicProblems.Implementation.Arrays
{
    /// <summary>
    /// 1.1 
    /// </summary>
    public static class IsUnique
    {
        public static bool IsUniqueLinear(string s)
        {
            var letters = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters.Contains(s[i]))
                    return false;
                letters.Add(s[i]);
            }

            return true;
        }
    }
}