using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class TicTacToeWinnerClass
    {
        public static string TicTacToeWinner(string board)
        => board.Split('|').CheckLines('x') ? "Player X is the winner"
            : board.Split('|').CheckLines('o') ? "Player O is the winner"
            : "Game is a tie";

        public static bool CheckLines(this string[] board, char C)
            => board.Any(o => o == new string(C, 3)) || board.CheckVertical(C) || board.CheckDiagonal(C);

        public static bool CheckVertical(this string[] board, char C)
            => Enumerable.Range(0, 3).Any(i => board.All(l => l[i] == C));

        public static bool CheckDiagonal(this string[] board, char C)
            => Enumerable.Range(0, 3).Select(i => board[i][i]).All(o => o == C)
                || Enumerable.Range(0, 3).Select(i => board[i][2 - i]).All(o => o == C);
    }
}
