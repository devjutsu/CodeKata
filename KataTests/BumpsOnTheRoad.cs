using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class BumpsOnTheRoadTest
    {
        [TestCase("n", "Woohoo!")]
        [TestCase("_nnnnnnn_n__n______nn__nn_nnn", "Car Dead")]
        [TestCase("______n___n_", "Woohoo!")]
        public void BasicTests(string input, string expected)
        {
            Assert.That(BumpsOnTheRoad.Bump(input), Is.EqualTo(expected));
        }
    }
}
