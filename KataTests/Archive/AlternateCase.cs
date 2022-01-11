using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class AlternateCaseTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("ABC", AlternateCase.alternateCase("abc"));
            Assert.AreEqual("abc", AlternateCase.alternateCase("ABC"));
            Assert.AreEqual("hELLO wORLD", AlternateCase.alternateCase("Hello World"));
        }
    }
}
