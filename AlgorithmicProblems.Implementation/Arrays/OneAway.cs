using System;

namespace AlgorithmicProblems.Implementation.Arrays
{
    // 1.5 One Away: You can insert/remove/replace one character. Given two strings, write a function to check if they are one edit away.
    public static class OneAway
    {
        public static bool Execute(string first, string second)
        {
            if (Math.Abs(first.Length - second.Length) > 1)
                return false;

            bool isOperationUsed = false;
            int i1 = 0, i2 = 0;
            
            while (i1 < first.Length && i2 < second.Length)
            {
                if (first[i1] != second[i2])
                {
                    if (isOperationUsed)
                        return false;
                    
                    isOperationUsed = true;
                    if (first.Length == second.Length)
                    {
                        i1++;
                        i2++;
                    }
                    else
                    {
                        if (first.Length > second.Length || first[i1 + 1] == second[i2])
                            i1++;
                        else if (first.Length < second.Length || second[i2 + 1] == first[i1])
                            i2++;
                        else
                            return false;
                    }
                }
                else
                {
                    i1++;
                    i2++;
                }
            }

            return true;
        }
    }
}