using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class DefineCardSuitTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("clubs", DefineCardSuit.DefineSuit("3♣"), "Should return clubs with \"3♣\"");
            Assert.AreEqual("spades", DefineCardSuit.DefineSuit("Q♠"), "Should return clubs with \"Q♠\"");
            Assert.AreEqual("diamonds", DefineCardSuit.DefineSuit("9♦"), "Should return clubs with \"9♦\"");
            Assert.AreEqual("hearts", DefineCardSuit.DefineSuit("J♥"), "Should return clubs with \"J♥\"");
        }
    }
}
