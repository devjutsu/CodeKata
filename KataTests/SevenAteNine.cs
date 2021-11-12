using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class SevenAteNineTest
    {
        [TestCase("165561786121789797", "16556178612178977")]
        [TestCase("797", "77")]
        [TestCase("7979797", "7777")]
        public void ExampleTests(string input, string expected)
        {
            Assert.That(SevenAte9.SevenAteNine(input), Is.EqualTo(expected));
        }
    }
}
