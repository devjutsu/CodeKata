using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataLib
{
    public class SevenAte9
    {
        public static string SevenAteNine(string str)
            => str.Replace("797", "77").Replace("797", "77");

        // Regex.Replace(str, @"(?<=7)9(?=7)", "");
    }
}
