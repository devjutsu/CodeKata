using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            return TimeUnits.Parse(seconds).ToString();
        }

        public class TimeUnits
        {
            public int Source { get; set; }
            public int Seconds { get; set; }
            public int Minutes { get; set; }
            public int Hours { get; set; }
            public int Days { get; set; }
            public int Years { get; set; }

            public static TimeUnits Parse(int source)
            {
                var time = new TimeUnits()
                {
                    Source = source
                };

                time.Years = source / (60 * 60 * 24 * 365);
                source %= (60 * 60 * 24 * 365);

                time.Days = source / (60 * 60 * 24);
                source %= (60 * 60 * 24);

                time.Hours = source / (60 * 60);
                source %= (60 * 60);

                time.Minutes = source / 60;
                source %= 60;
                
                time.Seconds = source;

                return time;
            }

            public override string ToString()
            {
                var seconds = Seconds == 0 ? "" : AboveSeconds
                                                    ? $"and {SecondStr}"
                                                    : SecondStr;

                var minutes = Minutes == 0 ? "" : Seconds == 0 && AboveMinutes
                                                    ? $"and {MinuteStr}"
                                                    : $"{MinuteStr}, ";

                var hours = Hours == 0 ? "" : !BelowHours && AboveHours
                                                ? $"and {HourStr}"
                                                : $"{HourStr}, ";

                var days = Days == 0 ? "" : Years > 0 && !BelowDays
                                                ? $"and {DayStr}"
                                                : $"{DayStr}, ";

                var years = Years == 0 ? "" : !BelowYears
                                                ? $"{YearStr}"
                                                : $"{YearStr}, ";

                var res = $"{years}{days}{hours}{minutes}{seconds}";
                res = res.Replace(", and", " and");
                if(res.EndsWith(", "))
                    res = res.Substring(0, res.Length - 2);

                return !string.IsNullOrEmpty(res) ? res : "now";
            }

            string YearStr => Years == 0 ? "" : Years == 1 ? "1 year" : $"{Years} years";
            string DayStr => Days == 0 ? "" : Days == 1 ? "1 day" : $"{Days} days";
            string HourStr => Hours == 0 ? "" : Hours == 1 ? "1 hour" : $"{Hours} hours";
            string MinuteStr => Minutes == 0 ? "" : Minutes == 1 ? "1 minute" : $"{Minutes} minutes";
            string SecondStr => Seconds == 0 ? "" : Seconds == 1 ? "1 second" : $"{Seconds} seconds";
            bool AboveSeconds => Source > 60;
            bool AboveMinutes => Source > 60*60;
            bool AboveHours => Days > 0 || Years > 0;
            bool BelowHours => Seconds > 0 || Minutes > 0;
            bool BelowDays => BelowHours || Hours > 0;
            bool BelowYears => BelowDays || Days > 0;
        }
    }
}
