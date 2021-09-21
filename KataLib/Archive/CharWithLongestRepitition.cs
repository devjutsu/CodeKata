using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class CharWithLongestRepitition
    {
        public static Tuple<char?, int> LongestRepetition(string input)
            => string.IsNullOrEmpty(input)
               ? new Tuple<char?, int>((char?)null, 0)
               : Regex.Matches(input, @"(.)\1+")
                        .BestMatch(input);

        public static Tuple<char?, int> BestMatch(this MatchCollection matches, string input)
            => matches.OrderByDescending(o => o.Value.Length)
                        .Select(o => new Tuple<char?, int>(o.Value.First(), o.Value.Length))
                        .FirstOrDefault() 
                        ?? new Tuple<Char?, Int32>(input.First(), 1);

    }
}
