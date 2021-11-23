using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class LastDigitsOfNumberTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { 1 }, LastDigitsOfNumber.LastDigit(1, 1));
            Assert.AreEqual(new[] { 3, 7, 6, 7 }, LastDigitsOfNumber.LastDigit(123767, 4));
            Assert.AreEqual(new[] { 0 }, LastDigitsOfNumber.LastDigit(0, 1));
            Assert.AreEqual(new[] { 5, 6, 4, 7, 8, 6, 7, 5, 8, 5 }, LastDigitsOfNumber.LastDigit(34625647867585, 10));
            Assert.AreEqual(new int[] { }, LastDigitsOfNumber.LastDigit(1234, 0));
            Assert.AreEqual(new int[] { }, LastDigitsOfNumber.LastDigit(24134, -4));
            Assert.AreEqual(new[] { 1, 3, 4, 3 }, LastDigitsOfNumber.LastDigit(1343, 5));
        }
    }
}
