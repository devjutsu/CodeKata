using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    public class BattleshipFieldTest
    {
        [Test]
        public void TestCase()
        {
            int[,] field = new int[10, 10]
                         {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                          {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                          {1, 0, 1, 0, 1, 1, 0, 0, 1, 0},
                          {1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                          {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                          {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                          {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                          {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                          {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                          {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.IsFalse(BattleshipField.ValidateBattlefield(field));
        }
    }
}
