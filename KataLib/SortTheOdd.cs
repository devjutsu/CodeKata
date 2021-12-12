using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class SortTheOdd
    {
        public static int[] SortArray(int[] arr)
            => arr.SortOdd(new Stack<int>(arr.Where(x => x % 2 == 1).OrderByDescending(x => x)));

        public static int[] SortOdd(this int[] arr, Stack<int> stack)
            => arr.Select((x, i) => x % 2 == 1 ? stack.Pop() : x).ToArray();
    }
}
