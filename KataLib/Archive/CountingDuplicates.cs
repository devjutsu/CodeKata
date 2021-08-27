using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public partial class Kata
    {
        public static int DuplicateCount(string str)
            => str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);

        //public static int DuplicateCountBad(string str)
        //    => RecursiveCount(str.ToLower(), "", "");

        //public static int RecursiveCount(string str, string already, string duplicates)
        //    => str.Length == 0
        //            ? duplicates.Length
        //            : already.Contains(str.First())
        //                ? duplicates.Contains(str.First())
        //                    ? RecursiveCount(str.Substring(1), already, duplicates)
        //                    : RecursiveCount(str.Substring(1), already, duplicates + str.First())
        //                : RecursiveCount(str.Substring(1), already + str.First(), duplicates);
    }
}
