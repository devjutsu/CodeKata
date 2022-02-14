using System;
using System.Collections.Generic;
using System.Linq;
namespace KataLib;

public class FindTheUniqueNumber
{
    public static int GetUnique(IEnumerable<int> numbers)
        => numbers.GroupBy(o => o).Where(z => z.Count() == 1).First().Key;
}