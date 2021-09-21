using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Fibonacci
    {
        public static int fib(int n)
            => (n < 2) ? n : fib(n - 1) + fib(n - 2);

        //public static int fib(int n)
        //{
        //    double phi = 0.5 + 0.5 * Math.Sqrt(5);
        //    return (int)Math.Round((Math.Pow(phi, n) - Math.Pow(-phi, 1 / n)) / Math.Sqrt(5));
        //}
    }

}
