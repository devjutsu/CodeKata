using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class TwistedSumTest
    {
        [Test]
        public void When03_Then6()
        {
            Assert.AreEqual(6, TwistedSum.Solution(3));
        }
        [Test]
        public void When10_Then46()
        {
            Assert.AreEqual(46, TwistedSum.Solution(10));
        }
        [Test]
        public void When11_Then48()
        {
            Assert.AreEqual(48, TwistedSum.Solution(11));
        }
        [Test]
        public void When12_Then51()
        {
            Assert.AreEqual(51, TwistedSum.Solution(12));
        }
    }
}
