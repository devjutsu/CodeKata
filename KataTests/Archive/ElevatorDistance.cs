using KataLib.Archive;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests.Archive
{
    internal class ElevatorDistanceTest
    {
        private static void Act(int[] array, int expected)
        {
            var msg = $"Invalid answer for array: [{string.Join(",", array)}]";
            var actual = ElevatorDistanceKata.ElevatorDistance(array);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase(new[] { 5, 2, 8 }, 9)]
        [TestCase(new[] { 1, 2, 3 }, 2)]
        [TestCase(new[] { 7, 1, 7, 1 }, 18)]
        public void FixedTests(int[] array, int expected)
        {
            Act(array, expected);
        }
    }
}
