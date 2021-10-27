using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class ComfortableWordsTest
    {
        [Test]
        public void ConfortableWords()
        {
            Assert.AreEqual(true, ComfortableWords.ComfortableWord("yams"), "yams is a confortable word");
            Assert.AreEqual(true, ComfortableWords.ComfortableWord("odor"), "odor is a confortable word");
            Assert.AreEqual(true, ComfortableWords.ComfortableWord("their"), "their is a confortable word");
        }

        [Test]
        public void NotConfortableWords()
        {
            Assert.AreEqual(false, ComfortableWords.ComfortableWord("leisure"), "leisure is NOT a confortable word");
            Assert.AreEqual(false, ComfortableWords.ComfortableWord("touts"), "touts is NOT a confortable word");
            Assert.AreEqual(false, ComfortableWords.ComfortableWord("test"), "test is NOT a confortable word");
        }
    }
}
