using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class ShortestWordTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));
            Assert.AreEqual(2, ShortestWord.FindShort("Let's travel abroad shall we"));
        }
    }
}
