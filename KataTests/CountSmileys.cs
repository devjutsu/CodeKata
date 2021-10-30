using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class CountSmileysTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(4, CountSmileysClass.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
            Assert.AreEqual(2, CountSmileysClass.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
            Assert.AreEqual(1, CountSmileysClass.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            Assert.AreEqual(0, CountSmileysClass.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
        }
    }
}
