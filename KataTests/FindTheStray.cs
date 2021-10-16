using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class FindTheStrayTest
    {
        [Test]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, FindTheStray.Stray(new int[] { 1, 1, 2 }));
        }
    }
}
