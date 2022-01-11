using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class OnesAndZeroesTest
    {
        int[] Test1 = new int[] { 0, 0, 0, 0 };
        int[] Test2 = new int[] { 1, 1, 1, 1 };
        int[] Test3 = new int[] { 0, 1, 1, 0 };
        int[] Test4 = new int[] { 0, 1, 0, 1 };
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(0, OnesAndZeroes.binaryArrayToNumber(Test1));
            Assert.AreEqual(15, OnesAndZeroes.binaryArrayToNumber(Test2));
            Assert.AreEqual(6, OnesAndZeroes.binaryArrayToNumber(Test3));
            Assert.AreEqual(5, OnesAndZeroes.binaryArrayToNumber(Test4));
        }
    }
}
