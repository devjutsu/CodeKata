using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class NextHigherNumberTest
    {
        [Test]
        public void smile67KataTest_withoutRandomZ()
        {
            Assert.AreEqual(1027079971, new NextHigherNumber().nextHigher(1027079964));
        }
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual(256, new NextHigherNumber().nextHigher(128));
        }
        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual(2, new NextHigherNumber().nextHigher(1));
        }
        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual(1279, new NextHigherNumber().nextHigher(1022));
        }
        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual(191, new NextHigherNumber().nextHigher(127));
        }
        [Test]
        public void smile67KataTest_withoutRandom5()
        {
            Assert.AreEqual(1253359, new NextHigherNumber().nextHigher(1253343));
        }
    }
}
