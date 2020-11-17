using System.Collections.Generic;
using AlgorithmicProblems.Implementation.Structures;

namespace AlgorithmicProblems.Implementation.LinkedLists
{
    public class RemoveDups
    {
        public static Node<T> RemoveOptimal<T>(Node<T> head)
        {
            var knownValues = new HashSet<T>();
            var node = head;
            var previous = node;
            while (node != null)
            {
                if (!knownValues.Contains(node.Value))
                {
                    knownValues.Add(node.Value);
                    previous = node;
                }
                else
                {
                    previous.Next = node.Next;
                }
                
                node = node.Next;
            }

            return head;
        }

        public static Node<T> RemoveWithoutBuffer<T>(Node<T> head)
        {
            var currentNode = head;
            while (currentNode != null)
            {
                var runner = currentNode.Next;
                var previousRunner = currentNode;
                while (runner != null)
                {
                    if (runner.Value.Equals(currentNode.Value))
                    {
                        previousRunner.Next = runner.Next;
                    }
                    
                    runner = runner.Next;
                }

                currentNode = currentNode.Next;
            }

            return head;
        }
    }
}