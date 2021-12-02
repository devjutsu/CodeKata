using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class StringBreakersTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Thisi" + "\n" + "sanex" + "\n" + "ample" + "\n" + "strin" + "\n" + "g", StringBreakerz.StringBreakers(5, "This is an example string"));
        }
    }
}
