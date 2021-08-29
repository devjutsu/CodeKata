using System;
using System.Linq;

namespace KataLib
{
    public static class HighestScoringWord
    {
        public static string High(string s)
            => s.Split()
                    .Select(x => new { Count = x.WordCount(), Word = x })
                    .OrderByDescending(x => x.Count)
                    .Select(x => x.Word)
                    .First();

        public static int WordCount(this string word)
            => word.Select(x => (char)x - 96).Sum();

        //public static string High(string s)
        //{
        //    return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
        //}
    }
}
