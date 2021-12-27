using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
            => str.ToLower().GroupBy(o => o).All(o => o.Count() == 1);

        //  str.ToLower().Distinct().Count()==str.Length;
    }
}