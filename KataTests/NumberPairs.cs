using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class NumberPairsTest
    {
        [TestCase]
        public void getLargerNumber()
        {
            int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
            int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
            Assert.AreEqual(NumberPairs.getLargerNumbers(arr1, arr2), new int[] { 23, 64, 53, 17, 88 });
        }
    }
}
