using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    [TestFixture]
    public static class FactorialTest
    {
        [Test]
        public static void Tests()
        {
            Assert.AreEqual(1, Factorial.factorial(0));
            Assert.AreEqual(1, Factorial.factorial(1));
            Assert.AreEqual(2, Factorial.factorial(2));
            Assert.AreEqual(6, Factorial.factorial(3));
            Assert.AreEqual(24, Factorial.factorial(4));
            Assert.AreEqual(120, Factorial.factorial(5));
        }
    }
}
