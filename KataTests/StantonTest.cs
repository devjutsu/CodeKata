using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class StandonTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(3, Stanton.StantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));
        }
    }
}
