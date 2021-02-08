using System;
using System.Collections.Generic;
using System.Text;

namespace GOSLibraries.Enums
{
    public enum DayCountConventionEnum
    {
        US_NASD_30_360 = 1,
        Actual_Actual = 2,
        Actual_360 = 3,
        Actual_365 = 4,
        European_30_360 = 5,
        Isda_30_360 = 6,
        No_Leap_Year_365 = 7,
        No_Leap_Year_360 = 8,
        Actual_364 = 9
    }
}
