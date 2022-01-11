using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            return intervals
              .SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1))
              .Distinct()
              .Count();
        }

        //public static int SumIntervals((int, int)[] intervals)
        //{
        //    if (intervals.Length == 0)
        //        return 0;
        //    else if(intervals.Length == 1)
        //        return intervals.First().Item2 - intervals.First().Item1;

        //    var processed = new List<(int, int)>() { intervals.First() };

        //    foreach (var interval in intervals.Skip(1))
        //    {
        //        var cross = processed.Where(o => o.Crosses(interval));
        //        if (cross != null && cross.Any())
        //        {
        //            var tmp = cross.First();
        //            var combined = tmp.Combine(interval);
        //            processed[processed.IndexOf(tmp)] = tmp.Combine(interval);
        //        }
        //        else
        //        {
        //            processed.Add(interval);
        //        }
        //    }

        //    var finals = new List<(int, int)>() { processed.First() };

        //    foreach (var interval in processed.Skip(1))
        //    {
        //        var cross = finals.Where(o => o.Crosses(interval));
        //        if (cross != null && cross.Any())
        //        {
        //            var tmp = cross.First();
        //            var combined = tmp.Combine(interval);
        //            finals[finals.IndexOf(tmp)] = tmp.Combine(interval);
        //        }
        //        else
        //        {
        //            finals.Add(interval);
        //        }
        //    }


        //    var res = finals.Select(o => Math.Abs(o.Item2 - o.Item1)).ToList();
        //    return res.Sum();
        //}

        //public static (int, int) Combine(this (int, int) first, (int, int) second)
        //{
        //    (int, int) result = (Math.Min(first.Item1, second.Item1), Math.Max(first.Item2, second.Item2));
        //    return result;
        //}

        //public static bool Crosses(this (int, int) first, (int, int) second)
        //{
        //    return (
        //           first.Item1.TestRange(second.Item1, second.Item2)
        //        || first.Item2.TestRange(second.Item1, second.Item2)
        //        || second.Item1.TestRange(first.Item1, first.Item2)
        //        || second.Item2.TestRange(first.Item1, first.Item2)
        //        || (first.Item1 >= second.Item1 && first.Item2 <= second.Item2)
        //        || (second.Item1 >= first.Item1 && second.Item2 <= first.Item2));
        //}

        //static bool TestRange(this int numberToCheck, int bottom, int top)
        //{
        //    return (numberToCheck >= bottom && numberToCheck <= top);
        //}
    }
}
