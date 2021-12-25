using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class StrongestEvenNumberTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(2, StrongestEvenNumber.strongestEven(1, 2));
            Assert.AreEqual(8, StrongestEvenNumber.strongestEven(5, 10));
            Assert.AreEqual(48, StrongestEvenNumber.strongestEven(48, 56));
            Assert.AreEqual(192, StrongestEvenNumber.strongestEven(129, 193));

            Assert.AreEqual(1073741824, StrongestEvenNumber.strongestEven(377600064, 1082775699));
            Assert.AreEqual(536870912, StrongestEvenNumber.strongestEven(403346193, 652351979));
        }
    }
}
