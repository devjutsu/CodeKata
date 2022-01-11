using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class SingleCharPalindromesTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("OK", SingleCharPalindromes.solve("abba"));
            Assert.AreEqual("remove one", SingleCharPalindromes.solve("abbaa"));
            Assert.AreEqual("not possible", SingleCharPalindromes.solve("abbaab"));
            Assert.AreEqual("remove one", SingleCharPalindromes.solve("madmam"));
            Assert.AreEqual("not possible", SingleCharPalindromes.solve("raydarm"));
            Assert.AreEqual("OK", SingleCharPalindromes.solve("hannah"));

        }
    }
}
