using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class SumStringsTest
    {
        [Test]
        public void Given123And456Returns579()
        {
            Assert.AreEqual("579", SumStrings.sumStrings("123", "456"));
        }

        [Test]
        public void LongTest()
        {
            Assert.AreEqual("131151201344081895336534324866", SumStrings.sumStrings("50095301248058391139327916261", "81055900096023504197206408605"));
        }
    }
}
