using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class TrailingZeroesTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, TrailingZeroes.TrailingZeros(5));
            Assert.AreEqual(1, TrailingZeroes.TrailingZeros(6));
            Assert.AreEqual(2, TrailingZeroes.TrailingZeros(12));
            Assert.AreEqual(6, TrailingZeroes.TrailingZeros(25));
            Assert.AreEqual(131, TrailingZeroes.TrailingZeros(531));
            Assert.AreEqual(96165809, TrailingZeroes.TrailingZeros(384663263));
        }
    }
}
