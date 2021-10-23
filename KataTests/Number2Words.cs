using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class NumberTranslationTest
    {
        [Test]
        public void Number2WordsTest()
        {
            Assert.AreEqual("seven hundred ninety-three", NumberTranslation.Number2Words(793));
            Assert.AreEqual("zero", NumberTranslation.Number2Words(0));
            Assert.AreEqual("one", NumberTranslation.Number2Words(1));
            Assert.AreEqual("three", NumberTranslation.Number2Words(3));
            Assert.AreEqual("five", NumberTranslation.Number2Words(5));
            Assert.AreEqual("eight", NumberTranslation.Number2Words(8));
            Assert.AreEqual("three hundred one", NumberTranslation.Number2Words(301));
            Assert.AreEqual("eight hundred", NumberTranslation.Number2Words(800));
            Assert.AreEqual("six hundred fifty", NumberTranslation.Number2Words(650));
            Assert.AreEqual("one thousand", NumberTranslation.Number2Words(1000));
            Assert.AreEqual("one thousand three", NumberTranslation.Number2Words(1003));
            Assert.AreEqual("seven thousand three hundred", NumberTranslation.Number2Words(7300));
            Assert.AreEqual("one hundred seventy-nine thousand one hundred ninety-seven", NumberTranslation.Number2Words(179197));
        }
    }
}
