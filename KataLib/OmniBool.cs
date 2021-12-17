using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class OmniBool
    {
        public static bool operator ==(OmniBool obj1, bool obj2)
            => true;

        public static bool operator !=(OmniBool obj1, bool obj2)
            => false;

        public static explicit operator bool(OmniBool v)
            => true;
        
        public static OmniBool omnibool;
    }


    //public class Kata
    //{
    //    public static bool x = false;
    //    public static bool omnibool
    //    {
    //        get => x = !x;
    //    }
    //}
}
