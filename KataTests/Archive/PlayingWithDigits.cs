using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    [TestFixture]
    public class DigPowTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, DigPow.digPow(89, 1));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, DigPow.digPow(92, 1));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(2, DigPow.digPow(695, 2));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(51, DigPow.digPow(46288, 3));
        }
    }
}
