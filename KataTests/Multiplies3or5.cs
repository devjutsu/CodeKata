using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    [TestFixture]
    public class Multiplies3or5Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Multiplies3or5.Solution(10));
        }
    }
}
