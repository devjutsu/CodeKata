using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
            => $"{numbers.Split().Select(o => int.Parse(o)).Max()}" +
                    $" {numbers.Split().Select(o => int.Parse(o)).Min()}";
    }
}
