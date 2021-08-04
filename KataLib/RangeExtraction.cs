using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class RangeExtraction
    {
        public static string Extract(int[] args)
        =>
            args.Length < 3
            ? string.Join(",", args)
            : StringifyRanges(Ranges(args));


        public static List<(int start, int end)> Ranges(int[] args)
        {
            var result = new List<(int start, int end)>();
            // check if it's range or single number
            for (int i = 0; i < args.Length; i++)
            {
                (int start, int end)? tmp = null;
                int j = 3;
                var subclusterToCheck = args.Skip(i).Take(j).ToArray();
                var isCluster = IsValidCluster(subclusterToCheck);

                // till the end of this range
                while (isCluster && (i + j <= args.Length))
                {

                    subclusterToCheck = args.Skip(i).Take(j).ToArray();
                    isCluster = IsValidCluster(subclusterToCheck);

                    if (isCluster)
                    {
                        tmp = (args[i], args[i + j - 1]);
                    }
                    else
                    {
                        break;
                    }
                    j++;
                }

                // save single number or range
                if (tmp == null)
                    result.Add((args[i], args[i]));
                else
                {
                    result.Add(tmp.Value);
                    i += tmp.Value.end - tmp.Value.start;
                }

            }
            return result;
        }

        public static bool IsValidCluster(int[] args)
        =>
            (args.Max() - args.Min() == args.Length - 1)
            && args.Length > 2;

        public static string StringifyRanges(List<(int start, int end)> ranges)
        {
            return string.Join(",", ranges.Select(o => StringifyTuple(o.start, o.end)));
        }

        public static string StringifyTuple(int start, int end)
        =>
            start == end
            ? $"{start}"
            : $"{start}-{end}";
    }
}
