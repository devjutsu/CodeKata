using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class RoundUpToNextMultupleOf5Test
    {
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 5)]
        [TestCase(3, ExpectedResult = 5)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(7, ExpectedResult = 10)]
        [TestCase(39, ExpectedResult = 40)]
        public static int FixedTest(int n)
        {
            return RoundUpToNextMultupleOf5.RoundToNext5(n);
        }
    }
}
