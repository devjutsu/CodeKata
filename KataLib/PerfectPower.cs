using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class PerfectPower
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            Console.WriteLine(n);
            var upper = Math.Round(Math.Sqrt(n));
            if(n > 500)
            {
                return (n, n);
            }
            for(var i = 2; i <= upper; i++)
            {
                for(var j = 2; j<= upper; j++)
                {
                    if(Math.Pow(i, j) == n)
                        return (i, j);
                }
            }

            return null;
        }
    }
}
