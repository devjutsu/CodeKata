using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Kata
    {
        public static string OddOrEven(int[] array)
        =>
            array.Sum() % 2 == 0
                    ? "even"
                    : "odd";
    }
}
