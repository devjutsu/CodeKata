using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class ConsecutiveLettersTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, ConsecutiveLetters.solve("abc"));
            Assert.AreEqual(false, ConsecutiveLetters.solve("abd"));
            Assert.AreEqual(true, ConsecutiveLetters.solve("dabc"));
            Assert.AreEqual(false, ConsecutiveLetters.solve("abbc"));
        }
    }
}
