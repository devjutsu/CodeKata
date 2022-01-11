using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class BackspacesInStringTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("ac", BackspacesInString.CleanString("abc#d##c"));
            Assert.AreEqual("", BackspacesInString.CleanString("abc####d##c#"));
        }
    }
}
