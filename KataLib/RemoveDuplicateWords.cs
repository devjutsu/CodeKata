using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static partial class RemoveDuplicateWordsKata
    {
        public static string RemoveDuplicateWords(string s)
            => string.Join("", s.Split()
                                    .GroupBy(o => o)
                                    .Select(o => o.Key));


    }
}
