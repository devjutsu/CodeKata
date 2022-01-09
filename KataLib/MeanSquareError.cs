using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class MeanSquareError
    {
        public static double Solution(int[] firstArray, int[] secondArray)
            => firstArray.Select((x, i) => x - secondArray[i])
                    .Select(x => Math.Pow(x, 2)).Average();

        //public static double Solution(int[] xs, int[] ys) 
        //    => xs.Zip(ys, (x, y) => (x - y) * (x - y))
        //            .Average();
    }
}
