using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class TicTacToeWinnerTest
    {
        [Test]
        public static void ExampleTest()
        {
            Assert.AreEqual(
              "Player X is the winner",
              TicTacToeWinnerClass.TicTacToeWinner("xox|xxo|xoo"));

            Assert.AreEqual(
              "Player X is the winner",
              TicTacToeWinnerClass.TicTacToeWinner("xxx|oxo|.oo"));

            Assert.AreEqual(
              "Player X is the winner",
              TicTacToeWinnerClass.TicTacToeWinner(".ox|o.x|o.x"));
        }
    }
}
