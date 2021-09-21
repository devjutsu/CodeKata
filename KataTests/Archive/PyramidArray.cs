using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class PyramidArrayTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[][] { new int[] { 1 }, new int[] { 1, 1 } }, PyramidArray.Pyramid(2));
            Assert.AreEqual(new int[][] { }, PyramidArray.Pyramid(0));
            Assert.AreEqual(new int[][] { new int[] { 1 } }, PyramidArray.Pyramid(1));
            Assert.AreEqual(new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 1, 1 } }, PyramidArray.Pyramid(3));
        }
    }
}
