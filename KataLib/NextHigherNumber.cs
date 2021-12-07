using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class NextHigherNumber
    {
        public int nextHigher(int value)
        {
            int rightOne, nextHigherOneBit, rightOnesPattern = 0;

            rightOne = value & -value;

            nextHigherOneBit = value + rightOne;
            rightOnesPattern = value ^ nextHigherOneBit;
            rightOnesPattern = rightOnesPattern / rightOne;

            rightOnesPattern >>= 2;

            return nextHigherOneBit | rightOnesPattern;
        }

        //public int nextHigher(int v)
        //{
        //    string bin = "0" + Convert.ToString(v, 2), left = Regex.Replace(bin, "0+$", ""), right = Regex.Match(bin, "0+$").Value;
        //    return Convert.ToInt32(Regex.Replace(left, "01(.*?)$", "10" + right + "$1", RegexOptions.RightToLeft), 2);
        //}

        //public int nextHigher(int value)
        //{
        //    int ones = Convert.ToString(value, 2).Where(x => x == '1').Count();
        //    do
        //    {
        //        value++;
        //    } while (Convert.ToString(value, 2).Where(x => x == '1').Count() != ones);
        //    return value;
        //}

        //public int nextHigher(int x)
        //{
        //    int o, n, p, r = 0;
        //    if (x != 0) { o = x & -x; n = x + o; p = x ^ n; p /= o; p >>= 2; r = n | p; }
        //    return r;
        //}
    }
}
