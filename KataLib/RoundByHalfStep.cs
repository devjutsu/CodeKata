using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class RoundByHalfStep
    {
        public static double Solution(double n)
            => ((n - Math.Floor(n)) < .25) ? Math.Floor(n)
                : ((n - Math.Floor(n)) < .75) ? Math.Floor(n) + .5
                    : Math.Floor(n) + 1;


        //public static double Solution(double n) 
        //    => Math.Round(n * 2) / 2;
    }
}
