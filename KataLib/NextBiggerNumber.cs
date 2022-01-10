using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class NextBiggerNumberClass
    {
        public static long NextBiggerNumber(long n)
        {
            var arr = n.ToString().Select(o => int.Parse(o.ToString())).ToArray();
            var i = 0;

            for(i = arr.Count() - 1; i > 0; i--)
                if(arr[i] > arr[i - 1])
                    break;

            if (i == 0)
                return -1;
            else
            {
                var x = arr[i - 1];
                var min = i;

                for (int j = i+1; j < arr.Length; j++)
                    if (arr[j] > x && arr[j] < arr[min])
                        min = j;

                var tmp = arr[i - 1];
                arr[i - 1] = arr[min];
                arr[min] = tmp;

                return long.Parse(String.Concat(arr[..i].Concat(arr[i..].OrderBy(x => x))));
            }
        }

        //public static long NextBiggerNumber(long n)
        //{
        //    String str = GetNumbers(n);
        //    for (long i = n + 1; i <= long.Parse(str); i++)
        //    {
        //        if (GetNumbers(n) == GetNumbers(i))
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        //public static string GetNumbers(long number)
        //{
        //    return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
        //}
    }
}
