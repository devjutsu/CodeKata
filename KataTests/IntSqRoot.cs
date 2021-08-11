using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    [TestFixture]
    public static class IntSqRootTests
    {

        [Test]
        public static void test1()
        {
            Assert.AreEqual(4, IntSqRoot.IntRac(25, 1));
            Assert.AreEqual(3, IntSqRoot.IntRac(125348, 300));
        }
    }

}
