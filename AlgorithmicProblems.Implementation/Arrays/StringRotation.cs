namespace AlgorithmicProblems.Implementation.Arrays
{
    // 1.9 String Rotation: Assume you have a method isSubstring which checks if one work is a substring of another.
    // Given two strings check if s2 is a rotation of s1 using only one call to isSubstring
    // Example: 'waterbottle' is a rotation of 'erbottlewat'
    public static class StringRotation
    {
        public static bool IsRotation(string source, string target)
        {
            if (source?.Length != target?.Length)
                return false;
            
            var combined = source + source + source;
            return IsSubstring(combined, target);
        }

        private static bool IsSubstring(string source, string target)
        {
            if (string.IsNullOrEmpty(target))
                return true;
            
            if (string.IsNullOrEmpty(source))
                return false;
            
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target[0])
                {
                    bool equal = true;
                    for (int j = 1; j < target.Length; j++)
                    {
                        if (i + j > source.Length)
                            return false;
                        if (target[j] != source[i + j])
                        {
                            equal = false;
                            break;
                        }
                    }

                    if (equal)
                        return true;
                }
            }

            return false;
        }
    }
}