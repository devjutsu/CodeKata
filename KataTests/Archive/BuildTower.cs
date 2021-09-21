using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class BuildTowerTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", BuildTower.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", BuildTower.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", BuildTower.TowerBuilder(3)));
        }
    }
}
