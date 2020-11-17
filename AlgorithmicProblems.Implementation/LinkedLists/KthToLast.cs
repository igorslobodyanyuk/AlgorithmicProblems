using AlgorithmicProblems.Implementation.Structures;

namespace AlgorithmicProblems.Implementation.LinkedLists
{
    public class KthToLast
    {
        public static int? Execute(Node<int> head, int k)
        {
            if (head == null)
                return null;
            
            // 1. count elements - N
            var current = head;
            int n = 0;
            while (current != null)
            {
                current = current.Next;
                n++;
            }
            
            // 2. loop to the element with index N - k and return it
            current = null;
            for (var i = 0; i < n - k; i++)
            {
                current = current == null ? head : current.Next;
            }

            return current?.Value;
        }
    }
}