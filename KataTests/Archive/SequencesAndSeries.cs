using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class SequencesAndSeriesTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(50, SequencesAndSeries.GetScore(1), "GetScore(1) returns a wrong result");
            Assert.AreEqual(150, SequencesAndSeries.GetScore(2), "GetScore(2) returns a wrong result");
            Assert.AreEqual(300, SequencesAndSeries.GetScore(3), "GetScore(3) returns a wrong result");
            Assert.AreEqual(500, SequencesAndSeries.GetScore(4), "GetScore(4) returns a wrong result");
            Assert.AreEqual(750, SequencesAndSeries.GetScore(5), "GetScore(5) returns a wrong result");
        }
    }
}
