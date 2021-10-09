using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class RomanNumeralsTest
    {
        [Test]
        public void TestToRoman_001()
        {
            int input = 1999;
            string expected = "MCMXCIX";

            string actual = RomanNumerals.ToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestToRoman_002()
        {
            int input = 2003;
            string expected = "MMIII";

            string actual = RomanNumerals.ToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFromRoman_001()
        {
            string input = "MCMXCIX";
            int expected = 1999;

            int actual = RomanNumerals.FromRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFromRoman_002()
        {
            string input = "MMIII";
            int expected = 2003;

            int actual = RomanNumerals.FromRoman(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
