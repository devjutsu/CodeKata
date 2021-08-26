using System;
using System.Collections.Generic;
using System.Linq;

namespace KataLib
{
    public static class AddBigNumbers
    {
        public static string Add(string a, string b)
            => string.Join("", Justify(a, b).Parse().Sum().Reverse());

        public static (IEnumerable<int>, IEnumerable<int>) Parse(this (string, string) items)
            => (items.Item1.Reverse().Select(x => int.Parse(x.ToString())), 
                    items.Item2.Reverse().Select(x => int.Parse(x.ToString())));

        public static string Sum(this (IEnumerable<int>, IEnumerable<int>) items, int acc = 0)
        => items.Item1.Count() > 0
            ? items.Item1.First() + items.Item2.First() + acc > 9
                ? items.Item1.First() + items.Item2.First() + acc - 10 + Sum((items.Item1.Skip(1), items.Item2.Skip(1)), 1)
                : items.Item1.First() + items.Item2.First() + acc + Sum((items.Item1.Skip(1), items.Item2.Skip(1)), 0)
            : acc > 0
                ? acc.ToString()
                : "";

        public static (string, string) Justify(string a, string b)
            => a.Length > b.Length
               ? (a, (new string('0', a.Length - b.Length) + b))
               : ((new string('0', b.Length - a.Length) + a), b);

        //public static string Add(string a, string b)
        //{
        //    (a, b) = Justify(a, b);

        //    var A = a.Reverse().ToList();
        //    var B = b.Reverse().ToList();

        //    var acc = 0;
        //    var result = new List<int>();
        //    for(var i = 0; i < a.Length; i++)
        //    {
        //        var c = int.Parse(A[i].ToString()) + int.Parse(B[i].ToString()) + acc;
        //        if (c > 9)
        //        {
        //            acc = 1;
        //            c -= 10;
        //        }
        //        else
        //            acc = 0;

        //        result.Add(c);
        //    }
        //    if (acc > 0)
        //        result.Add(acc);

        //    return string.Join("", result.AsEnumerable<int>().Reverse().ToArray());
        //}

        //public static (string, string) Justify(string a, string b)
        //    => a.Length > b.Length
        //       ? (a, (new string('0', a.Length - b.Length) + b))
        //       : ((new string('0', b.Length - a.Length) + a), b);

    }
}
