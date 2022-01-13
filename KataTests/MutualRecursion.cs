using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class MutualRecursionTest
    {
        [Test]
        public void BasicTests()
        {
            var f1 = MutualRecursion.F(43);
            Assert.AreEqual(1, MutualRecursion.F(0));
            Assert.AreEqual(0, MutualRecursion.M(0));

            Assert.AreEqual(1, MutualRecursion.F(1));
            Assert.AreEqual(0, MutualRecursion.M(1));

            Assert.AreEqual(2, MutualRecursion.F(2));
            Assert.AreEqual(1, MutualRecursion.M(2));


            //var test = Enumerable.Range(0, 100)
            //    .Select(x => new { f = MutualRecursion.F(x), m = MutualRecursion.M(x) })
            //    .ToList();

            //var f1 = MutualRecursion.F(43);
            //var m1 = MutualRecursion.M(43);
        }
    }
}
