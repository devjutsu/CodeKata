using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BumpsOnTheRoad
    {
        public static string Bump(string input)
            => input.Count(o => o == 'n') > 15 ? "Car Dead" : "Woohoo!";
    }
}
