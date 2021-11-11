using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class BuildASquareTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("", BuildASquare.GenerateShape(0));
            Assert.AreEqual("+", BuildASquare.GenerateShape(1));
            Assert.AreEqual("++\n++", BuildASquare.GenerateShape(2));
            Assert.AreEqual("+++\n+++\n+++", BuildASquare.GenerateShape(3));
        }
    }
}
