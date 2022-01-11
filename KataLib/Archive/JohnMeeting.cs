using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class JohnMeeting
    {
        public static string Meeting(string s)
            => string.Concat(s.ToUpper().Split(';')
                            .Select(o => o.Split(':'))
                            .OrderBy(o => o[1])
                            .ThenBy(o => o[0])
                            .Select(o => $"({o[1]}, {o[0]})"));
    }
}
