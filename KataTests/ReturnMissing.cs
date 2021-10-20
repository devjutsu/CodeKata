using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KataLib;

namespace KataTests
{
    internal class ReturnMissingTest
    {
        [Test]
        public void EightIsMissing()
        {
            Assert.AreEqual(8, ReturnMissing.GetMissingElement(new int[9] { 0, 5, 1, 3, 2, 9, 7, 6, 4 }));
        }

        [Test]
        public void ThreeIsMissing()
        {
            Assert.AreEqual(3, ReturnMissing.GetMissingElement(new int[9] { 9, 2, 4, 5, 7, 0, 8, 6, 1 }));
        }
    }
}
