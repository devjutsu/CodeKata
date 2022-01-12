using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class DigitsExplosionTest
    {
        [TestCase("312", "333122")]
        [TestCase("102269", "12222666666999999999")]
        public static void ExplodeTests(string s, string result)
        {
            Assert.AreEqual(result, DigitsExplosion.Explode(s));
        }
    }
}
