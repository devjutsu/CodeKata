using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
        
        // -------------------------------------------------------------

        //public static int find_it(int[] seq)
        //{
        //    return seq.Aggregate(0, (a, b) => a ^ b);
        //}

        // -------------------------------------------------------------

        //public static int find_it(int[] seq)
        //    => seq.GroupBy(o => o)
        //                    .Select(o =>new Tuple<int, int>(o.Key, o.Count()))
        //                    .Where(o => o.Item2.IsOdd())
        //                    .FirstOrDefault()?.Item1 ?? -1;

        //public static bool IsOdd(this int n)
        //    => n % 2 == 1;


        // -------------------------------------------------------------

        //public static int find_it(int[] seq)
        //{
        //    var counted = seq.GroupBy(o => o)
        //                    .Select(o => 
        //                                new Tuple<int, int> 
        //                                            (o.Key, o.Count())
        //                           )
        //                    .ToList();

        //    var odd = counted.FirstOrDefault(o => o.Item2.IsOdd());
        //    if (odd == null)
        //        return -1;
        //    else
        //        return odd.Item1;
        //}

        //public static bool IsOdd(this int n)
        //    => n % 2 == 1;
    }
}
