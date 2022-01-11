using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class OmniBoolTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.IsTrue(OmniBool.omnibool == true);
            Assert.IsTrue(OmniBool.omnibool == false);
        }
    }
}
