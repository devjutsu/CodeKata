using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var result = new Dictionary<string, List<int>>()
            {
                ["pos"] = new List<int>(),
                ["peaks"] = new List<int>()
            };

            for (var i = 1; i < arr.Length - 1; i++)
            {
                if (PrevLess(arr[..i], arr[i]) && PostLess(arr[(i+1)..], arr[i]))
                {
                    result["pos"].Add(i);
                    result["peaks"].Add(arr[i]);
                    
                    while(arr[i + 1].Equals(arr[i]) || i == arr.Length-1)
                    {
                        i++;
                    }
                }
            }

            return result;
        }

        public static bool PrevLess(int[] start, int x)
        {
            foreach(var item in start.Reverse())
            {
                if (x > item)
                    return true;
                else if (x < item)
                    return false;
            }

            
            return false;
        }

        public static bool PostLess(int[] end, int x)
        {
            foreach (var item in end)
            {
                if (x > item)
                    return true;
                else if (x < item)
                    return false;
            }

            return false;
        }
    }
}
