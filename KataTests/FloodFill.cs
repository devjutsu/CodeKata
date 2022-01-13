using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class FloodFillTest
    {
        [Test]
        public void TestExample()
        {
            var expected = new int[,]
              {{1,4,3},
               {1,4,4},
               {2,3,4}};

            var actual = new int[,]
              {{1,2,3},
               {1,2,2},
               {2,3,2}};

            CollectionAssert.AreEqual(expected, FloodFillClass.FloodFill(actual, 0, 1, 4));
        }
    }
}
