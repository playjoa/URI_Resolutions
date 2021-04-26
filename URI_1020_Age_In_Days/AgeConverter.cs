using System;

public static class AgeConverter
{
    const int days_in_Year = 365, days_in_Month = 30;
    
    public static void ConvertAgeFromDays(int daysToConvert)
    {
        int daysLeft = daysToConvert;

        int years_In_Age = ConvertDaysToYears(daysLeft);
        daysLeft %= days_in_Year;

        int months_In_Age = ConvertDaysToMonths(daysLeft);
        daysLeft %= days_in_Month;

        PrintValues(years_In_Age, months_In_Age, daysLeft);
    }

    static void PrintValues(int years_In_Age, int months_In_Age, int daysLeft)
    {
        Console.WriteLine(years_In_Age + " ano(s)");
        Console.WriteLine(months_In_Age + " mes(es)");
        Console.WriteLine(daysLeft + " dia(s)");
    }

    static int ConvertDaysToYears(int daysToConvert)
    {
        return daysToConvert / days_in_Year;
    }

    static int ConvertDaysToMonths(int daysToConvert)
    {
        return daysToConvert / days_in_Month;
    }
}
