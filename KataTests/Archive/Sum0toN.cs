using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KataLib;

namespace KataTests
{
    public class Sum0toNTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("0+1+2+3+4+5+6 = 21", Sum0toN.ShowSequence(6));
        }
    }
}
