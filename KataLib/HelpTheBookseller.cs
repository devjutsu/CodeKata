using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class HelpTheBookseller
    {
        public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
            => lstOfArt.Length == 0
                ? ""
                : lstOf1stLetter.StringifyResult(lstOfArt.GetMap());

        public static string StringifyResult(this string[] lst, Dictionary<string, int> map)
            => string.Join(" - ", 
                            lst.Select(o => $"({o} : {(map.ContainsKey(o) ? map[o] : 0)})"));

        public static Dictionary<string, int> GetMap(this String[] list)
            => list.Select(item => new { Count = int.Parse(Regex.Match(item, @"\d+").Value), Letter = item.First().ToString() })
                    .GroupBy(o => o.Letter)
                    .Select(o => new { Key = o.Key, Count = o.Sum(z => z.Count) })
                    .ToDictionary(t => t.Key, t => t.Count);

        //public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        //{
        //    if (!lstOfArt.Any()) return "";
        //    return string.Join(" - ",
        //      lstOf1stLetter.Select(c => string.Format("({0} : {1})", c,
        //        lstOfArt.Where(a => a[0] == c[0]).Sum(a => int.Parse(a.Split(' ')[1])))));
        //}
    }
}
