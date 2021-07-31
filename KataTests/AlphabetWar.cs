using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class AlphabetWar
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Left side wins!", Kata.AlphabetWar("wwwwwwz"));
            Assert.AreEqual("Let's fight again!", Kata.AlphabetWar("ffffff"));
            Assert.AreEqual("Let's fight again!", Kata.AlphabetWar(""));
            Assert.AreEqual("Right side wins!", Kata.AlphabetWar("z"));
            Assert.AreEqual("Let's fight again!", Kata.AlphabetWar("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", Kata.AlphabetWar("zzzzs"));
            Assert.AreEqual("Left side wins!", Kata.AlphabetWar("wwwwwwz"));
        }
    }
}
