using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class BowlingTest
    {
        [Test]
        public void exampleTests()
        {
            Bowling bowling = new Bowling();
            int[] testArray = new int[] { 1, 2, 3 };
            Assert.AreEqual("I I I I\n I I I \n       \n       ", bowling.BowlingPins(testArray));

            testArray = new int[] { 3, 5, 9 };
            Assert.AreEqual("I I   I\n I   I \n  I    \n   I   ", bowling.BowlingPins(testArray));
        }
    }
}
