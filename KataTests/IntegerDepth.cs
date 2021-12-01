using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class IntegerDepthTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(10, IntegerDepth.ComputeDepth(1));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(9, IntegerDepth.ComputeDepth(42));
        }
    }
}
