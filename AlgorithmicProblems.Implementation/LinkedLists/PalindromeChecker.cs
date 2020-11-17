using System.Linq;
using System.Reflection.Metadata;
using AlgorithmicProblems.Implementation.Structures;

namespace AlgorithmicProblems.Implementation.LinkedLists
{
    public static class PalindromeChecker
    {
        public static bool IsPalindrome<T>(Node<T> head)
        {
            if (head == null)
                return true;
            
            var items = head.ToList();
            items.Reverse();
            foreach (var reversedItem in items)
            {
                if (!reversedItem.Equals(head.Value))
                    return false;
                head = head.Next;
            }

            return true;
        }
    }
}