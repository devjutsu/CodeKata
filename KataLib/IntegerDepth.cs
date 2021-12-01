using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class IntegerDepth
    {
        public static int ComputeDepth(int n)
        {
            var numbers = "0123456789".ToList();
            var m = 0;
            do
            {
                (n * (++m)).ToString().ToList().ForEach(x => numbers.Remove(x));
            } while (numbers.Count() > 0);
            return m;
        }
    }
}
