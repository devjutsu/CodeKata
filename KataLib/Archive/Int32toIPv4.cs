using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Int32toIPv4
    {
        public static string UInt32ToIP(uint ip)
            => string.Join(".", (new int[] { 24, 16, 8, 0 }).Select(e => ip >> e & 255));

        //public static string UInt32ToIP(uint ip)
        //{
        //    var reversed = new IPAddress(ip).ToString().Split('.').Reverse();
        //    return string.Join(".", reversed);
        //}

        //public static string UInt32ToIP(uint ip)
        //  => IPAddress.Parse(ip.ToString()).ToString();


        //public static string UInt32ToIP(uint ip)
        //{
        //    var test = Convert.ToString(ip, 2).Reverse();

        //    var octet4 = "0" + string.Concat(test.Take(8).Reverse());
        //    var octet3 = "0" + string.Concat(test.Skip(8).Take(8).Reverse());
        //    var octet2 = "0" + string.Concat(test.Skip(16).Take(8).Reverse());
        //    var octet1 = "0" + string.Concat(test.Skip(24).Take(8).Reverse());

        //    return $"{Convert.ToInt32(octet1, 2)}.{Convert.ToInt32(octet2, 2)}.{Convert.ToInt32(octet3, 2)}.{Convert.ToInt32(octet4, 2)}";
        //}
    }
}
