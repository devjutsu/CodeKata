using System;
using System.Collections.Generic;
using System.Linq;

namespace KataLib
{
    public static class SudokuSolutionValidator
    {
        public static bool ValidateSolution(int[][] board)
        {
            if (board.HasZero())
                return false;

            //if (!board.All(x => x.CheckLine()))
            //    return false;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var split = board.Skip(i*3).Take(3).Select(o => o.Skip(j*3).Take(3).ToArray()).ToArray();
                    if (!split.CheckQuadrant())
                        return false;
                }
            }

            return true;
        }

        public static bool HasZero(this int[][] board)
        {
            var result =  (board.Select(x => string.Concat(x)).Any(x => x.Contains('0')));
            return result;
        }

        public static bool CheckLine(this int[] line)
            => line.Sum() == 45
                && line.GroupBy(n => n)
                        .All(x => x.Count() == 1);


        public static bool CheckQuadrant(this int[][] board)
        {
            var test = string.Concat(board.Select(x => string.Concat(x))).ToArray();

            if (!test.Select(o => int.Parse(o.ToString())).ToArray().CheckLine())
            {
                return false;
            }

            return true;
        }


        //public static List<List<int>> SplitBoard(int[][] board, int i = 0, int j = 0)
        //{
        //    var result = new List<List<int>>();


        //    return result;
        //}
    }
}
