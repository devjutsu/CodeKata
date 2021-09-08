using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class WeightSort
    {
        public static string orderWeight(string src)
            => string.Join(" ", src.Split()
                                .OrderBy(s => s.Sum(o => int.Parse(o.ToString())))
                                .ThenBy(s => s));


        //public static string orderWeight(string s)
        //{
        //    return string.Join(" ", s.Split(' ')
        //        .OrderBy(n => n.ToCharArray()
        //        .Select(c => (int)char.GetNumericValue(c)).Sum())
        //        .ThenBy(n => n));
        //}

    }
}
