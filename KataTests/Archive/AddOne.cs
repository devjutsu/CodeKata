using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class AddOneTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(4, AddOne.Add(1)(3));
        }
    }
}
