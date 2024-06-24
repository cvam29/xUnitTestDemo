using System;

namespace DaylightSavingTimeChecker.Tests;
public static class TimeZoneHelper
{
    public static bool IsInDaylightSavings(string timeZoneId, DateTime utcTime)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZone);
        return timeZone.IsDaylightSavingTime(localTime);
    }
}


