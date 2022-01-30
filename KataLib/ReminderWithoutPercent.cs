using System;
using System.Linq;
namespace KataLib;

public class ReminderWithoutPercent
{
    public static int Remainder(int D, int d)
        => D - (D / d) * (d);
}