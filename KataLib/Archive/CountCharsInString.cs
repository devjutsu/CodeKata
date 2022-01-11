using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class CountCharsInString
    {
        public static Dictionary<char, int> Count(string str)
            => str.GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());
    }
}
