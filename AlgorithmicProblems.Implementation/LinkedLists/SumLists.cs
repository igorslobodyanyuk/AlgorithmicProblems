using AlgorithmicProblems.Implementation.Structures;

namespace AlgorithmicProblems.Implementation.LinkedLists
{
    public static class SumLists
    {
        public static Node<int> Sum(Node<int> a, Node<int> b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;

            Node<int> sumHead = null, sum = null;
            var overflow = 0;
            while (a != null || b != null)
            {
                Node<int> current;
                (current, overflow) = SumReversed(a, b, overflow);

                if (sumHead == null)
                {
                    sumHead = sum = current;
                }
                else
                {
                    sum = sum.AssignNext(current);
                }

                a = a?.MoveNext();
                b = b?.MoveNext();
            }

            return sumHead;
        }

        private static (Node<int>, int) SumReversed(Node<int> a, Node<int> b, int overflow)
        {
            int current = (a?.Value ?? 0) + (b?.Value ?? 0) + overflow;
            if (current > 9)
            {
                overflow = current / 10;
                current %= 10;
            }
            else
            {
                overflow = 0;
            }

            return (new Node<int>(current), overflow);
        }

        public static void SumForward(Node<int> fromString, Node<int> ints)
        {
            throw new System.NotImplementedException();
        }
    }
}