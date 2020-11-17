using AlgorithmicProblems.Implementation.LinkedLists;
using AlgorithmicProblems.Implementation.Structures;
using Xunit;

namespace AlgorithmicProblems.Tests
{
    public class LinkedListsTest
    {
        // 2.1 Remove duplicates from unsorted linked list
        // How would you solve this without a temporary buffer?
        [Theory]
        [InlineData("","")]
        [InlineData("A>B>C","A>B>C")]
        [InlineData("A>A>A","A")]
        [InlineData("A>A>1>1>2>3","A>1>2>3")]
        public void RemoveDupsOptimalTest(string source, string target)
        {
            Assert.Equal(target, RemoveDups.RemoveOptimal(Node<string>.FromString(source))?.ToLinkedListString() ?? "");
        }
        
        [Theory]
        [InlineData("","")]
        [InlineData("A>B>C","A>B>C")]
        [InlineData("A>A>A","A")]
        [InlineData("A>A>1>1>2>3","A>1>2>3")]
        public void RemoveDupsWithoutBufferTest(string source, string target)
        {
            Assert.Equal(target, RemoveDups.RemoveWithoutBuffer(Node<string>.FromString(source))?.ToLinkedListString() ?? "");
        }

        /// <summary>
        /// 2.2 Implement an algorithm to return the k-th to last element in a singly linked list.
        /// </summary>
        [Theory]
        [InlineData("", -1, null)]
        [InlineData("1>2>3", 4, null)]
        [InlineData("1", 1, null)]
        [InlineData("1", 0, 1)]
        [InlineData("1>2>3>4>5", 0, 5)]
        [InlineData("1>2>3>4>5", 4, 1)]
        public void KthToLastTest(string source, int k, int? expected)
        {
            Assert.Equal(expected, KthToLast.Execute(Node<int>.FromString(source), k));
        }

        /// <summary>
        /// 2.3 Implement an algorithm to delete a node in the middle of the linked list (not first and not last)
        /// </summary>
        [Theory]
        [InlineData("", -1, "")]
        [InlineData("1", 0, "1")]
        [InlineData("1>2>3", 2, "1>2>3")]
        [InlineData("1>2>3>4>5", 2, "1>2>4>5")]
        [InlineData("1>2>3>4>5", 3, "1>2>3>5")]
        public void DeleteMiddleNodeTest(string source, int k, string expected)
        {
            var head = Node<int>.FromString(source);
            var nodeToDelete = head?.KthNode(k); 
            DeleteMiddleNode.Execute(nodeToDelete);
            Assert.Equal(expected, head?.ToLinkedListString() ?? "");
        }

        /// <summary>
        /// 2.4 Partition.
        /// Write code to partition a linked list around a value x such that all nodes less than x come before all nodes
        /// greater than or equal to x. (IMPORTANT: the partition element can appear anywhere in the "right partition";
        /// it does not need to appear between left and right partitions. The additional spacing in the example
        /// below indicates partition).
        /// </summary>
        /// <example>
        /// Input: 3>5>8>5>10>2>1 [partition = 5]
        /// Output: 3>1>2 > 10>5>5>8
        /// </example>
        [Theory]
        [InlineData("3>5>8>5>10>2>1", 5)]
        [InlineData("3>10>2>1", 5)]
        [InlineData("1", 5)]
        [InlineData("10>9>8>7>3>2>1", 0)]
        [InlineData("10>9>8>7>3>2>1", 11)]
        [InlineData("10>9>8>7>3>2>1", 7)]
        public void PartitionTest(string source, int partitionValue)
        {
            var partition = Partition.Execute(Node<int>.FromString(source), partitionValue);
            Assert.True(Partition.IsValidPartition(partition, partitionValue));
        }

        /// <summary>
        /// 2.4 Partition validation utility method
        /// </summary>
        /// <param name="source"></param>
        /// <param name="partitionValue"></param>
        /// <param name="isValid"></param>
        [Theory]
        [InlineData("1", 1, true)]
        [InlineData("1>3>2>5>5>7", 5, true)]
        [InlineData("1>3>2>5>5>7", 4, true)]
        [InlineData("10>9>8>7>3>2>1", 0, true)]
        [InlineData("3>5>8>5>10>2>1", 5, false)]
        public void IsValidPartitionTest(string source, int partitionValue, bool isValid)
        {
            Assert.Equal(isValid, Partition.IsValidPartition(Node<int>.FromString(source), partitionValue));
        }
        
        /// <summary>
        /// 2.5 You have two numbers represented by a linked list, where each node contains a single
        /// digit. The digits are stored in reverse order, such that the 1's digit is at the head of the list. Write a
        /// function that adds the two numbers and returns the sum as a linked list. (You are not allowed to
        /// "cheat" and just convert the linked list to an integer.) 
        /// </summary>
        /// <example>
        /// Input: (7>1>6) + (5>9>2) => that's 617+295
        /// Output: 2>1>9 => that's 912
        /// </example>
        [Theory]
        [InlineData("7>1>6", "5>9>2", "2>1>9")]
        [InlineData("7>1>6", "9", "6>2>6")]
        [InlineData("1", "5>9>2", "6>9>2")]
        [InlineData("7>1>6", "0", "7>1>6")]
        [InlineData("7>1>6", "", "7>1>6")]
        [InlineData("0", "0", "0")]
        public void SumListsTest(string a, string b, string sum)
        {
            Assert.Equal(sum, 
                SumLists.Sum(Node<int>.FromString(a), Node<int>.FromString(b)).ToLinkedListString());
        }
        
        /// <summary>
        /// 2.5 Follow up: suppose the digits  are stored in forward order. Repeat the above problem
        /// </summary>
        /// <example>
        /// Input: (6>1>7) + (2>9>5). That is 617+295
        /// Output: 9>1>2. That is 912.
        /// </example>
        [Theory]
        [InlineData("6>1>7", "2>9>6", "9>1>3")]
        [InlineData("6>1>7", "9", "6>2>6")]
        [InlineData("1", "5>9>2", "5>9>3")]
        [InlineData("7>1>6", "0", "7>1>6")]
        [InlineData("7>1>6", "", "7>1>6")]
        [InlineData("0", "0", "0")]
        public void SumListsFollowUpTest(string a, string b, string sum)
        {
            Assert.Equal(sum, 
                SumLists.SumForward(Node<int>.FromString(a), Node<int>.FromString(b)).ToLinkedListString());
        }

        /// <summary>
        /// 2.6 Implement a function to check if a linked list is a palindrome.
        /// </summary>
        [Theory]
        [InlineData("", true)]
        [InlineData("1", true)]
        [InlineData("1>2>3>4>3>2>1", true)]
        [InlineData("A>B>A", true)]
        [InlineData("A>B", false)]
        [InlineData("1>2", false)]
        [InlineData("1>2>3>4>5>4>3>2", false)]
        public void PalindromeTest(string source, bool isPalindrome)
        {
            Assert.Equal(isPalindrome, PalindromeChecker.IsPalindrome(Node<string>.FromString(source)));
        }

        /// <summary>
        /// 2.7 Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting
        /// node. Note that the intersection is defined based on reference, not value. That is, if the kth
        /// node of the first linked list is the exact same node (by reference) as the jth node of the second linked list,
        /// then they are intersecting.
        /// </summary>
        public void IntersectionTest()
        {
            
        }

        /// <summary>
        /// 2.8 Given a linked list which might contain a loop, implement an algorithm that returns the node
        /// at the beginning of the loop (if one exists).
        /// </summary>
        /// <example>
        /// Input: A>B>C>D>E>C (the same C as earlier)
        /// Output: C
        /// </example>
        public void LoopDetectionTest()
        {
            
        }
    }
}