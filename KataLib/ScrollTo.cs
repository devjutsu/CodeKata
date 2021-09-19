using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class ScrollTo
    {
        public static int GetSectionId(int n, int[] a)
            => Enumerable.Range(0, a.Length)
                        .Select(i => new { Index = i, Count = a.Take(i + 1).Sum() })
                        .Where(o => n < o.Count)
                        .FirstOrDefault()?.Index ?? -1;

        //public static int GetSectionId(int n, int[] a)
        //{
        //    return a.Sum() > n ? a.TakeWhile(s => (n -= s) >= 0).Count() : -1;
        //}

        //public static int GetSectionId(int n, int[] a)
        //{
        //    return a.Sum() > n ? a.Count(x => (n -= x) >= 0) : -1;
        //}
    }
}
