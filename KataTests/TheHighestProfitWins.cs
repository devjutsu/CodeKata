using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class TheHighestProfitWinsTest
    {
        [Test]
        public static void BasicTest()
        {
            Assert.AreEqual(new int[] { -1, 20 }, TheHighestProfitWins.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            Assert.AreEqual(new int[] { 1, 5 }, TheHighestProfitWins.minMax(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -3, 5 }, TheHighestProfitWins.minMax(new int[] { 1, 2, -3, 4, 5 }));
        }
    }
}
