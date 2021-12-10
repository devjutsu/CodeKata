using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BreakCamel
    {
        public static string BreakCamelCase(string str)
        => string.Concat(Enumerable.Range(0, str.Length - 1)
                                        .Select(i => char.IsLetterOrDigit(str[i]) && char.IsUpper(str[i + 1])
                                                ? str[i].ToString() + " " : str[i].ToString())) + str[^1];

        //public static string BreakCamelCase(string str) => new Regex("([A-Z])").Replace(str, " $1");

        // => string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));

    }
}
