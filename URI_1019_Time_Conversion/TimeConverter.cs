using System;

public static class TimeConverter
{
    const int seconds_in_hour = 3600, seconds_in_minute = 60;
    public static void ConvertSecondsToTimerView(int secondsToConvert)
    {
        int secondsLeft = secondsToConvert;

        int hoursInTimer = ConvertSecondsToHour(secondsLeft);
        secondsLeft %= seconds_in_hour;

        int minutesInTimer = ConvertSecondsToMinutes(secondsLeft);
        secondsLeft %= seconds_in_minute;

        PrintTimeConversion(hoursInTimer, minutesInTimer, secondsLeft);
    }

    static void PrintTimeConversion(int hoursInTimer, int minutesInTimer, int secondsLeft)
    {
        Console.WriteLine(hoursInTimer + ":" + minutesInTimer + ":" + secondsLeft);
    }

    static int ConvertSecondsToHour(int secondsToConvert)
    {
        return secondsToConvert / seconds_in_hour;
    }

    static int ConvertSecondsToMinutes(int secondsToConvert)
    {
        return secondsToConvert / seconds_in_minute;
    }
}