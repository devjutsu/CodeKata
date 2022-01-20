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
    public class LinkedListToStringTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("1 -> 2 -> 3 -> null", LinkedListToString.Stringify(new Node(1, new Node(2, new Node(3)))));
            Assert.AreEqual("0 -> 1 -> 4 -> 9 -> 16 -> null", LinkedListToString.Stringify(new Node(0, new Node(1, new Node(4, new Node(9, new Node(16)))))));
            Assert.AreEqual("null", LinkedListToString.Stringify(null));
        }
    }
}
