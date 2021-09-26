using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class MinimumUnfairness
    {
        public static int MinUnfairness(int[] arr, int k)
            => arr.Length <= 2 || k == 0
                    ? 0
                    : arr.OrderBy(o => o).ToArray().Res(k);

        public static int Res(this int[] arr, int k)
            => Enumerable.Range(0, arr.Length - k + 1)
                    .Select(i => arr[i + k - 1] - arr[i])
                    .Min(i => i);



        //public static int MinUnfairness(int[] arr, int k)
        //{
        //    if (arr.Length < 2 || k < 1)
        //        return 0;

        //    var sorted = arr.OrderBy(x => x).ToArray();
        //    var result = int.MaxValue;

        //    for(var i = 0; i <= arr.Length - k; i++)
        //    {
        //        result = Math.Min(result, sorted[i + k - 1] - sorted[i]);
        //    }

        //    return result;
        //}
    }
}
