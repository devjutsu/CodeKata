using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class CatalanTest
    {
        [Test]
        public void TestNumberZero()
        {
            BigInteger number = 1;
            Assert.AreEqual(number, Catalan.NthCatalanNumber(0), "Remember to use zero-based numbering");

        }
        [Test]
        public void TestNumberOne()
        {
            BigInteger number = 1;
            Assert.AreEqual(number, Catalan.NthCatalanNumber(1), "Remember to return BigInteger");
        }
        [Test]
        public void TestNumberTwo()
        {
            BigInteger number = 2;
            Assert.AreEqual(number, Catalan.NthCatalanNumber(2), "Remember to return BigInteger");
        }
        [Test]
        public void TestNumberThree()
        {
            BigInteger number = 5;
            Assert.AreEqual(number, Catalan.NthCatalanNumber(3), "Remember to return BigInteger");
        }
        [Test]
        public void TestNumberFour()
        {
            BigInteger number = 14;
            Assert.AreEqual(number, Catalan.NthCatalanNumber(4), "Remember to return BigInteger");
        }
    }
}
