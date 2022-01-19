using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace KataTests
{
    public class ClockwiseSpiralTest
    {
        [Test]
        public void Test1()
        {
            var expected = new int[,] { { 1 } };
            Assert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(1));
        }
        [Test]
        public void Test2()
        {
            var expected = new int[,]
            {
            {1, 2},
            {4, 3},
            };
            Assert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(2));
        }
        [Test]
        public void Test3()
        {
            var expected = new int[,]
            {
            {1, 2, 3},
            {8, 9, 4},
            {7, 6, 5}
            };
            Assert.AreEqual(expected, TheClockwiseSpiral.CreateSpiral(3));
        }
    }
}
