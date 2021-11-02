using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class NextSmallerNumber
    {
        public static long NextSmaller(long n)
        {
            if (n.ToString().Length < 2)
                return -1;

            var parsed = n.ToString().Select(o => int.Parse(o.ToString())).ToList();

            var itemIndex = parsed.ItemIndex();
            if (itemIndex == -1)
                return -1;
            else
            {
                var item = parsed[itemIndex];
                var smaller = parsed.Skip(itemIndex)
                                    .Select((o, i) => new { Item = o, Index = i })
                                    .Where(o => o.Item < parsed[itemIndex]).Last();

                if (itemIndex == 0 && smaller.Item == 0)
                    return -1;

                var left = parsed.Take(itemIndex).ToList();
                left.Add(smaller.Item);

                var right = parsed.Skip(itemIndex).ToList();
                right.Remove(smaller.Item);
                right = right.OrderByDescending(o => o).ToList();
                left.AddRange(right);

                return long.Parse(string.Concat(left));
            }
        }

        public static int ItemIndex(this List<int> arr)
        {
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if (arr.Skip(i).Any(o => arr[i] > o) && !(arr[i] == 0 && i == 1))
                    return i;
            }
            return -1;
        }
    }



    // Timed Out
    //public static long NextSmaller(long n)
    //{
    //    Console.WriteLine(n);
    //    if (n.ToString().Length < 2)
    //        return -1;

    //    var lste = n.ToString()
    //                .Select(o => int.Parse(o.ToString()))
    //                .ToList();

    //    var permuted = Combinations(lste)
    //                    .Select(o => long.Parse(string.Join("", o)))
    //                    .GroupBy(o => o)
    //                    .Select(o => o.Key)
    //                    .OrderBy(o => o)
    //                    .ToList();

    //    var index = permuted.IndexOf(n);
    //    if (index == 0
    //        || permuted[index - 1].ToString().Length < n.ToString().Length)
    //        return -1;
    //    else return
    //        permuted[index - 1];
    //}

    //public static List<string> Combinations<T>(IList<T> arr, List<string> list = null, string current = "")
    //{
    //    if (list == null) list = new List<string>();
    //    if (arr.Count == 0)
    //    {
    //        list.Add(current);
    //        return list;
    //    }
    //    for (int i = 0; i < arr.Count; i++)
    //    {
    //        List<T> lst = new List<T>(arr);
    //        lst.RemoveAt(i);
    //        Combinations(lst, list, current + arr[i].ToString());
    //    }
    //    return list;
    //}
}
