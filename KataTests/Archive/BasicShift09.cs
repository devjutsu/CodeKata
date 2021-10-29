using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class BasicShift09Test
    {
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual(2, new BasicShift09().nextLower(4));
        }
        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual(-4, new BasicShift09().nextLower(-3));
        }
        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual(16, new BasicShift09().nextLower(18));
        }
        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual(-32, new BasicShift09().nextLower(-16));
        }
    }
}
