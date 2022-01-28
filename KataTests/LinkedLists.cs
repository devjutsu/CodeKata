using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace KataTests
{
    public class LinkedListsTest
    {
        [Test, Description("tests for inserting a node before another node.")]
        public void pushTests()
        {
            Assert.AreEqual(1, Node.Push(null, 1).Data, "Should be able to create a new linked list with push().");
            Assert.AreEqual(null, Node.Push(null, 1).Next, "Should be able to create a new linked list with push().");
            Assert.AreEqual(2, Node.Push(new Node(1), 2).Data, "Should be able to prepend a node to an existing node.");
            Assert.AreEqual(1, Node.Push(new Node(1), 2).Next.Data, "Should be able to prepend a node to an existing node.");
        }

        [Test, Description("tests for building a linked list.")]
        public void buildTests()
        {
            Assert.AreEqual(1, Node.BuildOneTwoThree().Data, "First node should should have 1 as data.");
            Assert.AreEqual(2, Node.BuildOneTwoThree().Next.Data, "Second node should should have 2 as data.");
            Assert.AreEqual(3, Node.BuildOneTwoThree().Next.Next.Data, "Third node should should have 3 as data.");
            Assert.AreEqual(null, Node.BuildOneTwoThree().Next.Next.Next, "Third node should be the tail of the linked list");
        }

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("1 -> 2 -> 3 -> null", LinkedLists.Stringify(new Node(1, new Node(2, new Node(3)))));
            Assert.AreEqual("0 -> 1 -> 4 -> 9 -> 16 -> null", LinkedLists.Stringify(new Node(0, new Node(1, new Node(4, new Node(9, new Node(16)))))));
            Assert.AreEqual("null", LinkedLists.Stringify(null));
        }

        [Test, Description("tests for counting the length of a linked list.")]
        public void LengthTest()
        {
            Node list = Node.BuildOneTwoThree();
            Assert.AreEqual(0, Node.Length(null), "Length of null list should be zero.");
            Assert.AreEqual(1, Node.Length(new Node(99)), "Length of single node list should be one.");
            Assert.AreEqual(3, Node.Length(list), "Length of the three node list should be three.");
        }

        [Test, Description("tests for counting occurences of data that satisfies a condition.")]
        public void CountTest()
        {
            Node list = Node.BuildOneTwoThree();
            Assert.AreEqual(1, Node.Count(list, value => value == 1), "list should only contain one 1.");
            Assert.AreEqual(1, Node.Count(list, value => value == 2), "list should only contain one 2.");
            Assert.AreEqual(1, Node.Count(list, value => value == 3), "list should only contain one 3.");
            Assert.AreEqual(0, Node.Count(list, value => value == 99), "list should return zero for integer not found in list.");
            Assert.AreEqual(0, Node.Count(null, value => value == 1), "null list should always return count of zero.");

            Assert.AreEqual(2, Node.Count(list, value => value % 2 != 0), "list should contain two odd numbers.");
            Assert.AreEqual(1, Node.Count(list, value => value % 2 == 0), "list should contain one even number.");
        }

        [Test, Description("should be able to handle an empty list.")]
        public void EmptyTest()
        {
            Assert.AreEqual(12, Node.InsertNth(null, 0, 12).Data, "should be able to insert a node on an empty/null list.");
            Assert.AreEqual(null, Node.InsertNth(null, 0, 12).Next, "value at index 1 should be null.");
        }

        [Test, Description("should be able to insert a new node at the head of a list.")]
        public void TestIndex0()
        {
            Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Data, "should be able to insert new node at head of list.");
            Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Data, "value for node at index 1 should be 1.");
            Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Next.Data, "value for node at index 2 should be 2.");
            Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Next.Next.Data, "value for node at index 3 should be 3.");
            Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Next.Next.Next, "value at index 4 should be null.");
        }

        [Test, Description("should be able to insert a new node at index 1 of a list.")]
        public void TestIndex1()
        {
            Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Data, "value for node at index 0 should remain unchanged.");
            Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Data, "value for node at index 1 should be 23.");
            Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Next.Data, "value for node at index 2 should be 2.");
            Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Next.Next.Data, "value for node at index 3 should be 3.");
            Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Next.Next.Next, "value at index 4 should be null.");
        }

        [Test, Description("should be able to insert a new node at index 2 of a list.")]
        public void TestIndex2()
        {
            Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Data, "value for node at index 0 should remain unchanged.");
            Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Data, "value for node at index 1 should remain unchanged.");
            Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Next.Data, "value for node at index 2 should be 23.");
            Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Next.Next.Data, "value for node at index 3 should be 3.");
            Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Next.Next.Next, "value at index 4 should be null.");
        }

        [Test, Description("should be able to insert a new node at the tail of a list.")]
        public void TestIndex3()
        {
            Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Data, "head should remain unchanged after inserting new node at tail");
            Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Data, "value at index 1 should remain unchanged after inserting new node at tail");
            Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Next.Data, "value at index 2 should remain unchanged after inserting new node at tail");
            Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Next.Next.Data, "value for node at index 3 should be 23.");
            Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Next.Next.Next, "value at index 4 should be null.");
        }

        [Test, Description("should throw ArgumentOutOfRangeException if index is out of range")]
        public void ExceptionTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Node.InsertNth(Node.BuildOneTwoThree(), 4, 23), "Invalid index value should throw ArugmentException");
            Assert.Throws<ArgumentOutOfRangeException>(() => Node.InsertNth(Node.BuildOneTwoThree(), -4, 23), "Invalid index value should throw ArugmentException");
        }
    }
}
