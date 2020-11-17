using AlgorithmicProblems.Implementation.Structures;

namespace AlgorithmicProblems.Implementation.LinkedLists
{
    public class DeleteMiddleNode
    {
        public static Node<T> Execute<T>(Node<T> nodeToDelete)
        {
            if (nodeToDelete?.Next == null)
                return nodeToDelete;
            
            nodeToDelete.Value = nodeToDelete.Next.Value;
            nodeToDelete.Next = nodeToDelete.Next.Next;
            
            return nodeToDelete;
        }
    }
}