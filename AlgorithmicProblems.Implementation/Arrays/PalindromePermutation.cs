namespace AlgorithmicProblems.Implementation.Arrays
{
    // 1.4 Palindrome Permutation: given a string, write a function to check if it is a permutation of a palindrome. Ignore non letters and case.
    // Example: Tact Coa - true ('taco cat', 'atco cta')
    public static class PalindromePermutation
    {
        public static bool Execute(string source)
        {
            var letterCounts = new char[128];
            foreach (var c in source)
            {
                if (char.IsLetter(c))
                {
                    letterCounts[char.ToLower(c)]++;
                }
            }

            bool allowSingle = true;
            foreach (var letterCount in letterCounts)
            {
                if (letterCount % 2 != 0)
                {
                    if (allowSingle)
                        allowSingle = false;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}