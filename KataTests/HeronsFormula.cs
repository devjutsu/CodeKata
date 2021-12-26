using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class HeronsFormulaTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(6.0, HeronsFormula.heron(3, 4, 5));
        }
    }
}