using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class ParseIntReloaded
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual(0, Parser.ParseInt("zero"));
            Assert.AreEqual(1, Parser.ParseInt("one"));
            Assert.AreEqual(20, Parser.ParseInt("twenty"));
            Assert.AreEqual(246, Parser.ParseInt("two hundred forty-six"));
            Assert.AreEqual(783919, Parser.ParseInt("seven hundred eighty-three thousand nine hundred and nineteen"));
        }
    }
}
