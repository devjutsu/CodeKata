using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class WhichCentury
    {
        public static string WhatCentury(string year)
        {
            var yy = year[2] == '0' && year[3] == '0'
                        ? int.Parse(string.Concat(year.Take(2)))
                        : int.Parse(string.Concat(year.Take(2))) + 1;

            var y = year[2] == '0' && year[3] == '0'
                            ? (int.Parse(year[1].ToString()) - 1).ToString()[0]
                            : year[1];

            var test = year[0] == '1' ? "th"
                       : y == '0' ? "st"
                        : y == '1' ? "nd"
                        : y == '2' ? "rd"
                        : "th";
            var result = yy.ToString() + test;
            return result;
        }
    }
}
