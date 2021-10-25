using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Bearing
    {
        public Bearing(int n)
        {

        }
    }

    public static class IdentifyBearings
    {
        public static Bearing IdentifyBb(Bearing[] bearings, Func<IEnumerable<Bearing>, long> weigh)
        {
            var heap = bearings.SelectMany((o, i) => o.GetSome(i+1)).ToList();
            return bearings[weigh(heap) - heap.Count * 10 - 1];
        }

        public static Bearing[] GetSome(this Bearing b, int n)
            => Enumerable.Range(1, n).Select(o => b).ToArray();


        //public static Bearing IdentifyBb(Bearing[] bearings, Func<IEnumerable<Bearing>, long> weigh)
        //{
        //    return bearings[weigh(bearings.SelectMany(Enumerable.Repeat)) - 5 * bearings.Length * (bearings.Length - 1)];
        //}
    }
}
