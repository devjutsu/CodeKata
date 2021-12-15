using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DictionaryMerger
    {
        public static Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            return dicts.SelectMany(d => d)
                        .ToLookup(x => x.Key, x => x.Value)
                        .ToDictionary(x => x.Key, x => x.ToArray());
        }

        //public static Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        //{
        //    var result = new Dictionary<TKey, TValue[]>();

        //    foreach(var dict in dicts)
        //    {
        //        foreach(var item in dict)
        //        {
        //            if(result.ContainsKey(item.Key))
        //            {
        //                var values = result[item.Key];
        //                result[item.Key] = values.Concat(new TValue[] { item.Value }).ToArray();
        //            }
        //            else
        //            {
        //                result.Add(item.Key, new TValue[] { item.Value });
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
