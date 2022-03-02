using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class SumOfPositiveTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int ExampleTest(int[] arr)
        {
            return SumOfPositive.PositiveSum(arr);
        }
    }
}
