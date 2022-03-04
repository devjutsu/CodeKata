using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class LargestFive
    {
        public static int GetNumber(string str)
        {
            if (str.Length <= 5)
                return int.Parse(str);

            var largest = 0;
            for (var i = 0; i < str.Length-4; i++)
            {
                if (str[i] >= largest.ToString()[0])
                {
                    var test = int.Parse(string.Concat(str.Skip(i).Take(5)));
                    if (test > largest)
                        largest = test;
                }
            }
            return largest;
        }
    }
}
