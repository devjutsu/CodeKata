using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class NarcissisticKata
    {
        public static bool Narcissistic(int value)
        => value.ToString()
                    .Select(o => int.Parse(o.ToString()))
                    .Select(n => Math.Pow(n, value.ToString().Length))
                    .Sum() == value;
    }
}
