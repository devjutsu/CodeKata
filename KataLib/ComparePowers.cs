using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ComparePowersKata
    {
        public static int ComparePowers(int[] a, int[] b)
            => Math.Pow(b[0], b[1]).CompareTo(Math.Pow(a[0], a[1]));


        //public static int ComparePowers(int[] a, int[] b)
        //    => Res(Math.Pow(a[0], a[1]), Math.Pow(b[0], b[1]));

        //static int Res(double a, double b)
        //    => a == b ? 0 : a > b ? -1 : 1;
    }
}
