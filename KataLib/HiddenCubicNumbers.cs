using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class HiddenCubicNumbers
    {
        public static string isSumOfCubes(String src)
            => Regex.Matches(src, @"[\d]{1,3}")
                        .Select(o => o.Value)
                        .Where(o => o.IsCube())
                        .Select(o => int.Parse(o))
                        .StringifyCubes();

        public static string StringifyCubes(this IEnumerable<int> cubes)
            => cubes.Count() == 0
                ? "Unlucky"
                : $"{string.Join(" ", cubes)} {cubes.Sum()} Lucky";

        public static bool IsCube(this string src)
            => src.Digits().Sum(d => d * d * d) == int.Parse(src)
                ? true
                : false;

        public static IEnumerable<int> Digits(this string src)
            => src.ToCharArray().Select(o => int.Parse(o.ToString()));
    }
}
