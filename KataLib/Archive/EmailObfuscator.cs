using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class EmailObfuscator
    {
        public static string Obfuscate(string email)
        {
            return email.Replace(".", " [dot] ").Replace("@", " [at] ");
        }
    }
}
