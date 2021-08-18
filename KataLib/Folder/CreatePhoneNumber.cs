using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public partial class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        =>
            $"({string.Join("", numbers.Take(3))})"
            + $" {string.Join("", numbers.Skip(3).Take(3))}"
            + $"-{string.Join("", numbers.Skip(6).Take(4))}";
    }
}
