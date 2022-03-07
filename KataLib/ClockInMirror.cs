using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ClockInMirror
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            var hours = int.Parse(timeInMirror.Split(":")[0]);
            var mins = int.Parse(timeInMirror.Split(":")[1]);

            var newHours = hours == 12 && mins == 0 ? 12
                            : mins == 0 ? 12 - hours
                            : 12 - hours - 1;

            if (newHours < 1)
                newHours += 12;

            var newMins = mins == 0 ? 0
                            : 60 - mins;

            return $"{newHours.ToString("D2")}:{newMins.ToString("D2")}";
        }
    }
}

