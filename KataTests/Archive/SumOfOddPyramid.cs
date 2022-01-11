using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class SumOfOddPyramidTest
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(74088, SumOfOddPyramid.rowSumOddNumbers(42));
            Assert.AreEqual(1, SumOfOddPyramid.rowSumOddNumbers(1));
        }
    }
}
