using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class WorldBitsWarTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(WorldBitsWar.BitsWar(new List<int> { 1, 5, 12 }), "odds win");
            Assert.AreEqual(WorldBitsWar.BitsWar(new List<int> { 7, -3, 20 }), "evens win");
            Assert.AreEqual(WorldBitsWar.BitsWar(new List<int> { 7, -3, -2, 6 }), "tie");
            Assert.AreEqual(WorldBitsWar.BitsWar(new List<int> { -3, -5 }), "evens win");
            Assert.AreEqual(WorldBitsWar.BitsWar(new List<int>()), "tie");
        }
    }
}
