using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class FizzBuzz
    {
        public static string[] GetFizzBuzzArray(int n)
        => Enumerable.Range(1, n)
                    .Select(x =>
                                x % 3 == 0 && x % 5 == 0 ? "FizzBuzz"
                                : x % 3 == 0 ? "Fizz"
                                : x % 5 == 0 ? "Buzz"
                                : $"{x}").ToArray();
    }
}
