using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class RemoveTheMinimum
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if(numbers.Count() == 0)
                return numbers;
            var min = numbers.IndexOf(numbers.Min());
            numbers.RemoveAt(min);
            return numbers;
        }
    }
}
