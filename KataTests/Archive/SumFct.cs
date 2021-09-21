using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    [TestFixture]
    public class SumFctTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new BigInteger(80), SumFct.perimeter(new BigInteger(5)));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(new BigInteger(216), SumFct.perimeter(new BigInteger(7)));
        }
    }
}
