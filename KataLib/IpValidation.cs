using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace KataLib
{
    public partial class Kata
    {
        public static bool is_valid_IP(string ipAddress)
        =>
            IPAddress.TryParse(ipAddress, out IPAddress ip)
            && ip.ToString() == ipAddress;

        // ---------------------------------------------------------
        public static bool is_valid_IP2(string ipAddres)
        =>
            CheckOctets(ipAddres.Split('.'));

        public static bool CheckOctets(string[] array)
        =>
            array.Length == 4
            && array.ToList().All(x => CheckOctet(x));

        public static bool CheckOctet(string octet)
        =>
            int.TryParse(octet, out int result)
                            && result >= 0
                            && result <= 255
                            && result.ToString() == octet;
    }
}
