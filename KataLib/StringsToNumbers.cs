using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class stringArrayMethods
    {
        public static double[] ToDoubleArray(string[] stringArray)
            => stringArray.Select(o => double.Parse(o)).ToArray();
    }
}
