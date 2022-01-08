using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class PreviosMultipleOfThreeTest
    {
        private static void Act(int n, int? expected)
        {
            var msg = $"Invalid answer for n: {n}";
            var actual = PreviosMultipleOfThree.PreviousMultipleOfThree(n);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase(1, null)]
        [TestCase(25, null)]
        [TestCase(36, 36)]
        [TestCase(1244, 12)]
        [TestCase(952406, 9)]
        public void SampleTests(int n, int? expected)
        {
            Act(n, expected);
        }
    }
}
