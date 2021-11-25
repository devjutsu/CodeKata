using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class ReverseIntegerBitsTest
    {
        [Test(Description = "Sample tests")]
        public void SampleTests()
        {
            Assert.AreEqual(267, ReverseIntegerBits.ReverseBits(417));
            Assert.AreEqual(417, ReverseIntegerBits.ReverseBits(267));
            Assert.AreEqual(0, ReverseIntegerBits.ReverseBits(0));
            Assert.AreEqual(1087, ReverseIntegerBits.ReverseBits(2017));
            Assert.AreEqual(1023, ReverseIntegerBits.ReverseBits(1023));
            Assert.AreEqual(1, ReverseIntegerBits.ReverseBits(1024));
            Assert.AreEqual(long.MaxValue, ReverseIntegerBits.ReverseBits(long.MaxValue));
        }
    }
}
