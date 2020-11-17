using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AlgorithmicProblems.Implementation.Common;

namespace AlgorithmicProblems.Implementation.Structures
{
    public class Node<T> : IEnumerable<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node()
        {
            Value = default;
        }
        
        public Node(T value)
        {
            Value = value;
        }

        public Node<T> AssignNext(Node<T> nextNode) => Next = nextNode;

        public Node<T> AppendToTail(T value)
        {
            var node = this;
            while (node.Next != null)
            {
                node = node.Next;
            }
            
            node.Next = new Node<T>(value);
            return node;
        }

        /// <summary>
        /// Appends node to head if it exist. If It doesn't, return node.
        /// </summary>
        /// <returns>Appended node.</returns>
        public static Node<T> AppendNode(Node<T> head, Node<T> nodeToAppend)
        {
            if (head == null)
                return nodeToAppend;

            head.Next = nodeToAppend;
            return nodeToAppend;
        }

        public static Node<T> AppendValue(Node<T> head, T value)
        {
            return AppendNode(head, new Node<T>(value));
        }
        
        public static Node<T> DeleteNode(Node<T> head, T value)
        {
            if (head.Value.Equals(value))
                return head.Next;

            var node = head;
            while (node.Next != null)
            {
                if (node.Next.Value.Equals(value))
                {
                    node.Next = node.Next.Next;
                    break;
                }
            }

            return head;
        }

        public static Node<T> FromString(string sourceString, string separator = ">")
        {
            return FromEnumerable(
                sourceString
                    .Split(separator)
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Select(s => s.Convert<T>()));
        }

        public static Node<T> FromEnumerable(IEnumerable<T> source)
        {
            Node<T> previous = null;
            Node<T> head = null;
            foreach (var value in source.EmptyIfNull())
            {
                var current = new Node<T>(value);
                if (previous == null)
                {
                    head = previous = current;
                }
                else
                {
                    previous.Next = current;
                    previous = previous.Next;
                }
            }

            return head;
        }

        public string ToLinkedListString(string separator = ">")
        {
            var nodes = new List<Node<T>>();
            var node = this;
            while (node != null)
            {
                nodes.Add(node);
                node = node.Next;
            }

            return string.Join(separator, nodes);
        }

        public Node<T> KthNode(int k)
        {
            var current = this;
            for (int i = 0; i < k; i++)
            {
                if (current == null)
                    return null;

                current = current.Next;
            }

            return current;
        }

        #region Standard overrides
        
        public override string ToString()
        {
            return Value.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(this, obj as Node<T>);
        }

        protected bool Equals(Node<T> other)
        {
            return EqualityComparer<T>.Default.Equals(Value, other.Value) && Equals(Next, other.Next);
        }

        public bool Equals(Node<T> x, Node<T> y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return EqualityComparer<T>.Default.Equals(x.Value, y.Value);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Next);
        }
        
        #endregion
    }
    
    public static class NodeExtensions
    {
        public static Node<T> MoveNext<T>(this Node<T> node)
        {
            if (node == null || !node.HasNext())
                return null;
            return node.Next;
        }

        public static bool HasNext<T>(this Node<T> node) => node?.Next != null;
    }
}