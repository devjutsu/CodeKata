using System;
using System.Collections.Generic;
using System.Linq;

namespace KataLib
{
    public static class SudokuSolutionValidator
    {
        public static bool ValidateSolution(int[][] board)
            => !board.ContainsZero()
                && board.All(x => x.CheckLine())
                && board.CheckQuadrants();

        public static bool ContainsZero(this int[][] board)
            => board.Select(x => string.Concat(x))
                        .Any(x => x.Contains('0'));

        public static bool CheckLine(this IEnumerable<int> line)
            => line.Sum() == 45
                && line.GroupBy(n => n)
                        .All(x => x.Count() == 1);

        public static bool CheckQuadrants(this int[][] board, int i = 0)
            => i >= 3 || board.CheckSlice(i) && board.CheckQuadrants(i + 1);

        public static bool CheckSlice(this int[][] board, int i, int j = 0)
            => j >= 3 || board.Check3x3(i, j) && board.CheckSlice(i, j + 1);

        public static bool Check3x3(this int[][] board, int i, int j)
            => board.Skip(i * 3)
                        .Take(3)
                        .Select(o => o.Skip(j * 3)
                                        .Take(3))
                        .SelectMany(x => x)
                        .CheckLine();

        //public static bool ValidateSolution(int[][] board)
        //{
        //    return Enumerable
        //      .Range(0, 9)
        //      .SelectMany(i => new[]
        //      {
        //  board[i].Sum(),
        //  board.Sum(b => b[i]),
        //  board.Skip(3 * (i / 3)).Take(3).SelectMany(r => r.Skip(3 * (i % 3)).Take(3)).Sum()
        //      })
        //      .All(i => i == 45);
        //}

        //public static bool ValidateSolution(int[][] board) => Enumerable
        //    .Range(0, 9)
        //    .All(n =>
        //    {
        //        var y = 3 * (n / 3);
        //        var x = 3 * (n % 3);
        //        var hash = Enumerable
        //          .Range(y, 3)  // 3*3 matrix
        //          .SelectMany(i => board[i].Skip(x).Take(3))
        //          .ToHashSet();
        //        return hash.Count() == 9 && !hash.Contains(0);
        //    });
    }
}
