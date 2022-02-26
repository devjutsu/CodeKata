using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    internal class WhichCenturyTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("20th", WhichCentury.WhatCentury("2000"), "With input '2259' solution produced wrong output.");
            Assert.AreEqual("23rd", WhichCentury.WhatCentury("2259"), "With input '2259' solution produced wrong output.");
            Assert.AreEqual("20th", WhichCentury.WhatCentury("1999"), "With input '1999' solution produced wrong output.");
            Assert.AreEqual("21st", WhichCentury.WhatCentury("2011"), "With input '2011' solution produced wrong output.");
            Assert.AreEqual("22nd", WhichCentury.WhatCentury("2154"), "With input '2154' solution produced wrong output.");
        }
    }
}
