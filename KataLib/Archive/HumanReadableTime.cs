using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
            => string.Format("{0:d2}:{1:d2}:{2:d2}", 
                                seconds / 3600, 
                                seconds / 60 % 60, 
                                seconds % 60);

        //public static string GetReadableTime(int seconds)
        //    => $"{Hours(seconds):00}:" +
        //        $"{Minutes(seconds):00}:" +
        //        $"{(seconds - Hours(seconds) * 3600 - Minutes(seconds) * 60):00}";

        //public static int Hours(int seconds)
        //    => seconds / 3600;

        //public static int Minutes(int seconds)
        //    => (seconds - (seconds / 3600) * 3600) / 60;
    }
}
