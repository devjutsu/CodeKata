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
    public static class DryPotatoesTests
    {

        private static void dotest(int p0, int w0, int p1, int expected)
        {
            Assert.AreEqual(expected, DryPotatoes.Potatoes(p0, w0, p1));
        }

        [Test]
        public static void test()
        {
            Console.WriteLine("Fixed Tests: Potatoes");
            dotest(99, 100, 98, 50);
            dotest(93, 129, 91, 100);
            dotest(82, 127, 80, 114);
        }
    }
}
