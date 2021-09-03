using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            int[] oneline = field.Cast<int>().ToArray();
            int j = 0;
            int[][] jagged = oneline.GroupBy(x => j++ / field.GetLength(1))
                                        .Select(y => y.ToArray())
                                        .ToArray();

            return oneline.Sum() == 20
                    && jagged.MatchesShipCountAndSizes();
        }

        public static bool MatchesShipCountAndSizes(this int[][] field)
        {
            return false;
        }



    }
}
