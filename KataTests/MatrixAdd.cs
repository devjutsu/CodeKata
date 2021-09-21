using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class MatrixAdditionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[][] {new int[] {3, 5},
                                   new int[] {3, 5}}, MatrixAdd.MatrixAddition(new int[][] {new int[] {1, 2},
                                                                                       new int[] {1, 2}},
                                                                                             new int[][] {new int[] {2, 3},
                                                                                                    new int[] {2, 3}}));
        }
    }
}
