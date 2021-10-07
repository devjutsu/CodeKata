using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KataLib;

namespace KataTests
{
    internal class SpiralizorTest
    {
        [Test]
        public void Test05()
        {
            int input = 5;
            int[,] expected = new int[,]{
            {1, 1, 1, 1, 1},
            {0, 0, 0, 0, 1},
            {1, 1, 1, 0, 1},
            {1, 0, 0, 0, 1},
            {1, 1, 1, 1, 1}
        };

            int[,] actual = Spiralizor.Spiralize(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test08()
        {
            int input = 8;
            int[,] expected = new int[,]{
            {1, 1, 1, 1, 1, 1, 1, 1},
            {0, 0, 0, 0, 0, 0, 0, 1},
            {1, 1, 1, 1, 1, 1, 0, 1},
            {1, 0, 0, 0, 0, 1, 0, 1},
            {1, 0, 1, 0, 0, 1, 0, 1},
            {1, 0, 1, 1, 1, 1, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 1},
            {1, 1, 1, 1, 1, 1, 1, 1},
        };

            int[,] actual = Spiralizor.Spiralize(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
