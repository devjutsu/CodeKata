using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class By3Test
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(By3.DivisibleByThree("1891009"), Is.EqualTo(false));
            Assert.That(By3.DivisibleByThree("00009"), Is.EqualTo(true));
            Assert.That(By3.DivisibleByThree("57"), Is.EqualTo(true));
        }
    }
}
