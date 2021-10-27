using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace KataLib
{
    public static class StringMix
    {
        public static string Mix(string s1, string s2)
        {
            var ss1 = Regex.Replace(s1, "[^a-z]", "")
                            .GroupBy(o => o)
                            .Select((o, i) => new { Key = o.Key, Count = o.Count(), S = 1, I = i}).ToList();

            var ss2 = Regex.Replace(s2, "[^a-z]", "")
                            .GroupBy(o => o)
                            .Select((o, i) => new { Key = o.Key, Count = o.Count(), S = 2, I = i }).ToList();

            ss1.AddRange(ss2);

            var sorted = ss1.Where(o => o.Count > 1)
                            .GroupBy(o => o.Key)
                            .OrderByDescending(o => o.Max(z => z.Count))
                            .ThenBy(o => (o.Count() == 2 && o.First().Count == o.Last().Count ) ? 2 : 1)
                            .ThenBy(o => o.OrderByDescending(z => z.Count).First().S)
                            .ThenBy(o => o.Key)
                            .ToList();

            var result = sorted.Select(o => new
            {
                S = ((o.Count() == 2 && o.First().Count == o.Last().Count)) ? "=" : o.OrderByDescending(z => z.Count).First().S.ToString(),
                C = o.Key,
                Times = o.OrderByDescending(z => z.Count).First().Count
            }).Select(o => $"{o.S}:{new string(o.C, o.Times)}").ToList();

            return string.Join('/', result);
        }




        public static string Mix_Shorter(string s1, string s2)
        {
            var s1Group = s1.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var s2Group = s2.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var s12Group = s1Group.Concat(s2Group).GroupBy(a => a.letter, b => b);

            var sGrouped = s12Group.Select(a => new {
                count = a.OrderByDescending((p => p.count)).First().count,
                letter = a.Key,
                winner = s1.Count(i => i == a.Key) > s2.Count(i => i == a.Key)
                                                ? "1" : s1.Count(i => i == a.Key) < s2.Count(i => i == a.Key) ? "2" : "="
            });

            return string.Join("/", sGrouped.Where(o => o.count > 1).OrderByDescending(o => o.count)
            .ThenBy(o => int.Parse(o.winner == "=" ? "3" : o.winner))
            .ThenBy(o => o.letter).Select(gz => gz.winner + ":" + new string(gz.letter, gz.count)));
        }
    }
}
