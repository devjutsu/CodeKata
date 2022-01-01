using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class TicTacToeChecker
    {
        public int IsSolved(int[,] board)
            => (HasLine(board, 1) || DiagonalLine(board, 1)) ? 1
                : (HasLine(board, 2) || DiagonalLine(board, 1)) ? 2
                : IsFull(board) ? 0
                : -1;

        public bool HasLine(int[,] board, int player)
            => Enumerable.Range(0, 3)
                    .Select(x =>
                        Enumerable.Range(0, 3)
                            .Select(y => board[x, y] == player).All(o => o == true))
                    .Any(o => o == true)
            || Enumerable.Range(0, 3)
                    .Select(x =>
                        Enumerable.Range(0, 3)
                            .Select(y => board[y, x] == player).All(o => o == true))
                    .Any(o => o == true);

        public bool DiagonalLine(int[,] board, int player)
            => Enumerable.Range(0, 3).Select(i => board[i, i]).All(o => o == player)
                || Enumerable.Range(0, 3).Select(i => board[i, 2 - i]).All(o => o == player);

        public bool IsFull(int[,] board)
             => Enumerable.Range(0, 3)
                .SelectMany(x => Enumerable.Range(0, 3).Select(y => board[x, y] != 0)).All(o => o == true);
    }
}
