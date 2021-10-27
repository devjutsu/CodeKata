using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class AreaOfCircle
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            double.TryParse(radius, out double rad);
            if (rad == 0 || rad < 0 || radius.Contains(','))
                throw new ArgumentException();

            return Math.Round(Math.PI * rad * rad, 2);
        }
    }
}
