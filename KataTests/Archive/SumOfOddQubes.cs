using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    class SumOfOddQubesTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(28, SumOfOddQubes.CubeOdd(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(0, SumOfOddQubes.CubeOdd(new int[] { -3, -2, 2, 3 }));
        }
    }
}
