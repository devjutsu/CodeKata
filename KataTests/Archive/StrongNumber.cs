using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KataLib;

namespace KataTests
{
    internal class StrongNumberTest
    {
        [TestCase(1, "STRONG!!!!")]
        [TestCase(2, "STRONG!!!!")]
        [TestCase(145, "STRONG!!!!")]
        [TestCase(7, "Not Strong !!")]
        [TestCase(93, "Not Strong !!")]
        [TestCase(185, "Not Strong !!")]
        public void BasicTests(int input, string expected)
        {
            Assert.That(StrongNumberCheck.StrongNumber(input), Is.EqualTo(expected));
        }
    }
}
