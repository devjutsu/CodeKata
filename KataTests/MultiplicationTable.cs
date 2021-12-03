using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class MultiplicationTableTest
    {
        [Test]
        public void MyTest()
        {
            int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
            Assert.AreEqual(expected, MultiplicationTabl.MultiplicationTable(3));
        }
    }
}
