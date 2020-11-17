using AlgorithmicProblems.Implementation.Structures;

namespace AlgorithmicProblems.Implementation.LinkedLists
{
    public static class Partition
    {
        public static Node<int> Execute(Node<int> head, int partition)
        {
            Node<int> resultPartition = null, resultHead = null, node = head;
            foreach (var value in node)
            {
                if (value < partition)
                {
                    resultPartition = Node<int>.AppendValue(resultPartition, value);
                    if (resultHead == null)
                    {
                        resultHead = resultPartition;
                    }
                }
            }
            
            node = head;
            foreach (var value in node)
            {
                if (value >= partition)
                {
                    resultPartition = Node<int>.AppendValue(resultPartition, value);
                    if (resultHead == null)
                    {
                        resultHead = resultPartition;
                    }
                }
            }

            return resultHead;
        }
        
        public static bool IsValidPartition(Node<int> head, int p)
        {
            bool reachedPartition = false;
            foreach (var nodeValue in head)
            {
                if (!reachedPartition)
                {
                    if (nodeValue > p)
                        reachedPartition = true;
                }
                else
                {
                    if (nodeValue < p)
                        return false;
                }
            }

            return true;
        }
    }
}