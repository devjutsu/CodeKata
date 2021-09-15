using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Day
    {
        public string countDays(DateTime d)
            => d.Date == DateTime.Today
                ? "Today is the day!"
                : d.Date < DateTime.Today
                    ? "The day is in the past!"
                    : $"{(d.Date - DateTime.Now).Days} days";
    }
}
