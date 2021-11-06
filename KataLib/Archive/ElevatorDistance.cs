using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib.Archive
{
    public class ElevatorDistanceKata
    {

        public static int ElevatorDistance(int[] array)
            => Enumerable.Range(0, array.Length - 1)
                        .Sum(i => Math.Abs(array[i] - array[i + 1]));

        //public static int ElevatorDistance(int[] a)
        //    => a.Aggregate(new { Prev = a.First(), List = new List<int>() }, (aggregate, current) =>
        //            {
        //                aggregate.List.Add(Math.Abs(current - aggregate.Prev));
        //                return new { Prev = current, aggregate.List };
        //            }).List.Sum();


    }
}
