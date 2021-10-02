using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DiffBetweenYears
    {
        public static int HowManyYears(string date1, string date2)
            => Math.Abs(DateTime.Parse(date1).Year - DateTime.Parse(date2).Year);
    }
}
