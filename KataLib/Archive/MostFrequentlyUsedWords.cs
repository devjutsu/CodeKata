using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class MostFrequentlyUsedWords
    {
        public static List<string> Top3(string s)
            => Regex.Matches(s.ToLower(), "[A-Za-z']+")
                            .Select(o => o.Value)
                            .Where(x => Regex.Match(x, "[A-Za-z]+").Success)
                            .GroupBy(o => o)
                            .OrderByDescending(o => o.Count())
                            .Take(3)
                            .Select(o => o.Key)
                            .ToList();
    }
}
