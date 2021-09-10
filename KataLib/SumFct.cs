using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class SumFct
    {
        public static BigInteger perimeter(BigInteger n)
            => Fibu(n + 1)*4;

        public static BigInteger Fibu(BigInteger n)
        {
            BigInteger f1 = 1;
            BigInteger f2 = 1;
            BigInteger tmp = 0;
            BigInteger result = 2;

            for (var i = 2; i < n; i++)
            {
                tmp = f1 + f2;
                f1 = f2;
                f2 = tmp;
                result += tmp;
            }
            return result;
        }


            //var test = Fibi(n + 1, 2, 1, 1, 2*4);
        //public static BigInteger Fibi(BigInteger n, BigInteger i, BigInteger f1, BigInteger f2, BigInteger res)
        //    => i == n 
        //            ? res 
        //            : Fibi(n, ++i, f2, f1 + f2, res + (f1 + f2) * 4);
    }
}
