using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    internal class DivisibleBy5Test
    {
        [Test, Description("Example Tests")]
        [TestCase("", ExpectedResult = false)]
        [TestCase("101", ExpectedResult = true)]
        [TestCase("1010", ExpectedResult = true)]
        [TestCase("10100", ExpectedResult = true)]
        [TestCase("1111110111111100", ExpectedResult = true)]
        [TestCase("10110101", ExpectedResult = false)]
        [TestCase("1110001", ExpectedResult = false)]
        [TestCase("‭00010101‬", ExpectedResult = false)]
        [TestCase("‭0011110000100000‬", ExpectedResult = false)]
        [TestCase("‭0101110000010101‬", ExpectedResult = false)]
        [TestCase("100101110010000", ExpectedResult = false)]
        [TestCase("1010101110100000", ExpectedResult = false)]
        [TestCase("1000000011010001", ExpectedResult = false)]
        [TestCase("101001000", ExpectedResult = false)]
        [TestCase("1011001100001", ExpectedResult = false)]
        public bool ExampleTests(string text)
        {
            return Regex.IsMatch(text, DivisibleBy5.DivisibleByFive);
        }
    }
}
