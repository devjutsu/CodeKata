using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class WorldBitsWar
    {
        public static string BitsWar(List<int> numbers)
            => Result(numbers.Where(o => (Math.Abs(o % 2)) == 1)
                                .Select(o => Math.Sign(o) * Convert.ToString(Math.Abs(o), 2).Where(z => z == '1').Count())
                                .Sum(),
                      numbers.Where(o => Math.Abs(o % 2) == 0)
                                .Select(o => Math.Sign(o) * Convert.ToString(Math.Abs(o), 2).Where(z => z == '1').Count())
                                .Sum());

        public static string Result(int odds, int evens)
            => odds == evens ? "tie" : odds > evens ? "odds win" : "evens win";




        //private static int f(int x)
        //=> (x % 2 == 0 ? 1 : -1) * Math.Sign(x) * Convert.ToString(Math.Abs(x), 2).Count(c => c == '1');

        //public static string BitsWar(List<int> numbers) => numbers.Sum(x => f(x)) switch
        //{
        //    int number when number < 0 => "odds win",
        //    int number when number > 0 => "evens win",
        //    _ => "tie"
        //};



        //public static string BitsWar(List<int> numbers)
        //{
        //    int sum = numbers.Sum(x => Math.Sign(x) * (x % 2 == 0 ? 1 : -1) * Convert.ToString(Math.Abs(x), 2).Count(c => c == '1'));
        //    return sum > 0 ? "evens win" : sum == 0 ? "tie" : "odds win";
        //}
    }
}
