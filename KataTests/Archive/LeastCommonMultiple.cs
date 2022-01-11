using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class LeastCommonMultipleTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.That(LeastCommonMultiple.Lcm(new List<int> { 2, 3, 4 }), Is.EqualTo(12));
            Assert.That(LeastCommonMultiple.Lcm(new List<int> { 2, 5 }), Is.EqualTo(10));
            Assert.That(LeastCommonMultiple.Lcm(new List<int> { 9 }), Is.EqualTo(9));
        }
    }
}
