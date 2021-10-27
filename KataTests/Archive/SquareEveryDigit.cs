using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    class SquareEveryDigitTest
    {
        [Test]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, SquareEveryDigit.SquareDigits(9119));
            Assert.AreEqual(0, SquareEveryDigit.SquareDigits(0));
        }
    }
}
