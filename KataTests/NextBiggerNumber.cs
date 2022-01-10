using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class NextBiggerNumberTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1608305302, NextBiggerNumberClass.NextBiggerNumber(1608305230));
            Assert.AreEqual(2071, NextBiggerNumberClass.NextBiggerNumber(2017));
            Assert.AreEqual(21, NextBiggerNumberClass.NextBiggerNumber(12));
            Assert.AreEqual(531, NextBiggerNumberClass.NextBiggerNumber(513));
            Assert.AreEqual(441, NextBiggerNumberClass.NextBiggerNumber(414));
            Assert.AreEqual(414, NextBiggerNumberClass.NextBiggerNumber(144));
        }
    }
}
