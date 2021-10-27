using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class LastSurvivorz
    {
        public static string LastSurvivor(string letters, int[] coords)
        => coords.Length > 0
                ? LastSurvivor(letters.Remove(coords[0], 1), coords.Skip(1).ToArray())
                : letters;


        // return coords.Aggregate(letters, (s, i) => s[..i] + s[(i + 1)..]);
    }
}
