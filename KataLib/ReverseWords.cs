using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class ReverseThem
    {
        public static string ReverseWords(string str)
            => string.Join(" ", str.Split(' ').Select(x => string.Concat(x.Reverse())));
    }
}
