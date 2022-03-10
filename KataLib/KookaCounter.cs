using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataLib
{
    public class KookaCounterClass
    {
        public static int KookaCounter(string laughing) 
            => Regex.Matches(laughing, "(Ha)+|(ha)+").Count;

        //public static int KookaCounter(string laughing)
        //{
        //    if (string.IsNullOrEmpty(laughing))
        //        return 0;
        //    var seq = laughing.Where(o => o != 'a').ToArray();
        //    var acc = 1;
        //    for(var i = 0; i<seq.Count()-1; i++)
        //    {
        //        if(seq[i] != seq[i+1])
        //            acc++;
        //    }

        //    return acc;
        //}
    }
}
