using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AlgorithmicProblems.Implementation.Common;

namespace AlgorithmicProblems.Implementation.Structures
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; }
        
        public SinglyLinkedList()
        {
        }

        public SinglyLinkedList(string sourceString, string separator = ">")
        {
            Head = Node<T>.FromString(sourceString, separator);
        }

        public SinglyLinkedList(IEnumerable<T> source)
        {
            Head = Node<T>.FromEnumerable(source);
        }

        public void AppendToTail(T value)
        {
            Head.AppendToTail(value);
        }

        public void DeleteFirst(T value)
        {
            Node<T>.DeleteNode(Head, value);
        }

        public override string ToString()
        {
            return string.Join(">",this.ToList());
        }

        #region IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            if (Head == null)
                yield break;
            
            Node<T> node;
            do
            {
                node = Head;
                yield return node.Value;
                node = node.Next;
            } while (node != null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        #endregion
    }
}