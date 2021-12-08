using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class LeastCommonMultiple
    {
        public static int Lcm(List<int> nums)
            => nums.Count == 0
            ? 1
            : nums.Aggregate((a, b) => (a * b) / GCD(a, b)); 

        static int GCD(int a, int b)
            => b == 0 ? a : GCD(b, a % b);
    }
}
