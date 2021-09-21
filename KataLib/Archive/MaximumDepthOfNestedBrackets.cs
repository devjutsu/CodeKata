using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class MaximumDepthOfNestedBrackets
    {
        public static List<string> StringsInMaxDepth(string s)
        {
            var strings = new List<(int, string)>();
            var depth = 0;
            var maxDepth = 0;
            var node = string.Empty;
            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        strings.Add((depth, node));
                        maxDepth = Math.Max(maxDepth, depth);
                        node = string.Empty;
                        depth++;
                        break;
                    case ')':
                        strings.Add((depth, node));
                        maxDepth = Math.Max(maxDepth, depth);
                        node = string.Empty;
                        depth--;
                        break;
                    default:
                        node += c;
                        break;
                }
            }

            return maxDepth == 0
                ? new List<string> { node }
                : strings
                    .Where(tuple => tuple.Item1 == maxDepth)
                    .Select(tuple => tuple.Item2)
                    .ToList();
        }


        //public static string[] StringsInMaxDepth(string source)
        //    => source.ExtractLevel(GetMax(source));

        //public static int GetMax(this string source, int level = 0, int max = 0)
        //{
        //    for (var i = 0; i < source.Length; i++)
        //    {
        //        level += source[i].LevelChange();

        //        if (level > max)
        //            max = level;
        //    }
        //    return max;
        //}

        //public static int LevelChange(this char c)
        //    => c == '(' ? 1 : c == ')' ? -1 : 0;

        //public static string[] ExtractLevel(this string source, int max)
        //{
        //    var level = 0;
        //    var result = new List<string>();
        //    if (source.Contains('('))
        //    {
        //        for (var i = 0; i < source.Length; i++)
        //        {
        //            level += source[i].LevelChange();

        //            if (level == max)
        //            {
        //                var openingBracketIndex = i;
        //                var closingBracketIndex = source.IndexOf(')', i + 1);
        //                var diff = closingBracketIndex - openingBracketIndex;
        //                result.Add(source.Substring(i + 1, diff - 1));

        //                for (var j = 1; j <= diff; j++)
        //                {
        //                    level += source[i + j].LevelChange();
        //                }
        //                i += diff;
        //            }
        //        }
        //        return result.ToArray();
        //    }
        //    else
        //    {
        //        return new string[] { source };
        //    }
        //}
    }
}
