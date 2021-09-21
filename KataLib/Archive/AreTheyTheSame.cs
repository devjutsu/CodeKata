using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class AreTheyTheSame
    {
        //public static bool comp(int[] a, int[] b)
        //{
        //    if (a == null || b == null) return false;
        //    var result = a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        //    return result;
        //}

        public static bool comp(int[] a, int[] b)
            => a == null || b == null
                ? a == null && b == null
                    ? true
                    : false
                : a.Length != b.Length
                    ? false
                    : a.ToList().Breakdown(b.ToList());

        public static bool Breakdown(this List<int> a, List<int> b)
            => a.Count() == 0 || b.Count() == 0
                ? a.Count() == 0 && b.Count() == 0
                    ? true
                    : false
                : b.Remove(a.First() * a.First())
                    ? Breakdown(a.Skip<int>(1).ToList(), b)
                    : false;

        //public static bool comp(int[] a, int[] b)
        //{
        //    if (a == null || b == null)
        //    {
        //        if (a == null && b == null)
        //            return true;
        //        else
        //            return false;
        //    }
        //    else if (a.Length != b.Length)
        //        return false;
        //    else
        //    {
        //        return a.ToList().Breakdown(b.ToList());
        //    }
        //}

        //public static bool Breakdown(this List<int> a, List<int> b)
        //{
        //    if(a.Count() == 0 || b.Count() == 0)
        //    {
        //        if (a.Count() == 0 && b.Count() == 0) return true;
        //        else return false;
        //    }
        //    else
        //    {
        //        var mul = a.First() * a.First();
        //        if (b.Remove(mul))
        //            return Breakdown(a.Skip<int>(1).ToList(), b); 
        //        else
        //            return false;
        //    }
        //}
    }
}
