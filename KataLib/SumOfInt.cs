using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataTests
{
    public class SumOfInt
    {
        public static int SumOfIntegersInString(string s)
        => Regex.Matches(s, @"\d+").Sum(o => int.Parse(o.Value));
    }
}
