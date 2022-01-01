using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class TicTacToeCheckerTest
    {
        private TicTacToeChecker tictactoe = new TicTacToeChecker();

        [Test]
        public void test1()
        {
            int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(1, tictactoe.IsSolved(board));
        }

        [Test]
        public void test2()
        {
            int[,] board = new int[,] { { 1, 2, 0 }, { 0, 1, 2 }, { 0, 0, 1 } };
            Assert.AreEqual(1, tictactoe.IsSolved(board));
        }
    }
}
