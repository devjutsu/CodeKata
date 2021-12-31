using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            return string
              .Join("\n", text.Split("\n")
              .Select(x => x.Split(commentSymbols, StringSplitOptions.None)[0]
              .TrimEnd(' ')));
        }

        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var tmp = text.Split("\n");
        //    foreach(var s in commentSymbols)
        //    {
        //        for(var i = 0; i < tmp.Length; i++)
        //        {
        //            var cutTo = tmp[i].IndexOf(s);
        //            if(cutTo != -1)
        //            {
        //                tmp[i] = tmp[i].Substring(0, cutTo);
        //            }
        //        }
        //    }
        //    return String.Join("\n", tmp.Select(o => o.TrimEnd()).ToArray()); ;
        //}
    }
}
