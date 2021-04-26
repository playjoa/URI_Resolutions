using System;
using Inputs;

namespace URI_1020_Age_In_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysToConvert = InputSystem.ReadIntNumber();

            AgeConverter.ConvertAgeFromDays(daysToConvert);

            Console.ReadKey();
        }
    }
}
