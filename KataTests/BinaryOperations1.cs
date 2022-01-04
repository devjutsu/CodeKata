using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class BinaryOperations1Test
    {
        [Test]
        public void test0()
        {
            Assert.AreEqual(255, BinaryOperations1.FlipBit(127, 8));
        }
        [Test]
        public void test1()
        {
            Assert.AreEqual(7, BinaryOperations1.FlipBit(15, 4));
        }
        [Test]
        public void test2()
        {
            Assert.AreEqual(1, BinaryOperations1.FlipBit(0, 1));
        }
        [Test]
        public void test3()
        {
            Assert.AreEqual(14, BinaryOperations1.FlipBit(15, 1));
        }
    }
}
