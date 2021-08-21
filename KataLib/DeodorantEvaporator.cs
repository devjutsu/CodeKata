using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class DeodorantEvaporator
    {
        //public static int evaporator(double content, double evap_per_day, double threshold)
        //{

        //    var initial = content;
        //    var n = 0;
        //    while(content > initial * 0.01 * threshold)
        //    {
        //        var diff = content * 0.01 * evap_per_day;
        //        content -= diff;
        //        n++;
        //    }

        //    return n;
        //}

        public static int evaporator(double content, double evap_per_day, double threshold)
            => content.recursion(evap_per_day, threshold, content);

        public static int recursion(this double content, double perday, double threshold, double initial)
            => content <= initial * 0.01 * threshold
                ? 0
                : 1 + recursion(content - content * 0.01 * perday, perday, threshold, initial);

    }
}
