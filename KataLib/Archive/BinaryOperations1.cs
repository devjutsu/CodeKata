using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BinaryOperations1
    {

        public static int FlipBit(int value, int bitIndex)
        {
            return (1 << bitIndex - 1) ^ value;
        }

        //public static int FlipBit(int value, int bitIndex)
        //{
        //    int r = 1;
        //    for (int i = 1; i < bitIndex; i++)
        //    {
        //        r *= 2;
        //    }
        //    return value ^ r;
        //}

        //public static int FlipBit(int value, int bitIndex)
        //{
        //    var bin = Convert.ToString(value, 2);
        //    bin = bin.Length > bitIndex ? bin : new string('0', bitIndex - bin.Length) + bin;
        //    var arr = bin.Reverse().ToArray();
        //    arr[bitIndex-1] = (arr[bitIndex-1] == '0' ? '1' : '0');
        //    bin = string.Concat(arr.Reverse());
        //    var result = Convert.ToInt32(bin, 2);
        //    return result;
        //}
    }
}
