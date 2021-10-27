using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class ComfortableWords
    {
        public static string left = "q, w, e, r, t, a, s, d, f, g, z, x, c, v, b";
        public static string right = "y, u, i, o, p, h, j, k, l, n, m";
        public static bool ComfortableWord(string word)
        => left.Contains(word.First())
                      ? word.Comfy(left, true) && word.Comfy(right, false)
                      : word.Comfy(left, false) && word.Comfy(right, true);

        public static bool Comfy(this string word, string side, bool even)
        => word.Select((o, i) => new { Index = i, Char = o })
                    .Where(o => o.Index % 2 == (even ? 0 : 1))
                    .All(o => side.Contains(o.Char));

    }

    //public bool ComfortableWord(string word)
    //{
    //    var s = string.Concat(word.Select(c => "yuiophjklnm".Contains(c) ? "R" : "L"));
    //    return !(s.Contains("LL") || s.Contains("RR"));
    //}

    //public bool ComfortableWord(string word)
    //{
    //    return !Regex.IsMatch(
    //      Regex.Replace(word, @"q|w|e|r|t|a|s|d|f|g|z|x|c|v|b", " "), @"\s{2}|\w{2}"
    //    );
    //}
}
