using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class ClosestToZero
    {
        public static int? Closest(int[] arr)
            => arr.Check(arr.Select(o => new { abs = Math.Abs(o), org = o })
                            .OrderBy(o => o.abs)
                            .First().org);

        public static int? Check(this int[] arr, int closest)
            => arr.Contains(0)
                ? 0
                : arr.Contains(closest) && arr.Contains(-closest)
                    ? null
                    : (int?)closest;


        //public static int? Closest(int[] arr)
        //{
        //    var ints = arr.Distinct().OrderBy(Math.Abs).Take(2).ToArray();
        //    return ints.First() == ints.Last() * -1 ? (int?)null : ints.First();
        //}
    }
}
