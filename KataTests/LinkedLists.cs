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
    }
}
