using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class CalculateInversionsTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, CalculateInversions.CountInversions(new int[] { 1, 2, 3 }), "Sorted array has 0 inversions");
            Assert.AreEqual(1, CalculateInversions.CountInversions(new int[] { 2, 1, 3 }), "Array [2,1,3] only has one inversion");
        }
    }
}
