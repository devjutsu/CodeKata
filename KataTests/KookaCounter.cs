using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class KookaCounterTest
    {
        private static object[] Basic_Test_Cases = new object[]
        {
          new object[] {String.Empty, 0},
          new object[] {"hahahahaha", 1},
          new object[] {"hahahahahaHaHaHa", 2},
          new object[] {"HaHaHahahaHaHa", 3}
        };

        [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
        public void Basic_Test(string laughing, int expected)
        {
            Assert.AreEqual(expected, KookaCounterClass.KookaCounter(laughing));
        }
    }
}
