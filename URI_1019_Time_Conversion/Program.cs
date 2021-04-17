using System;
using Inputs;

namespace URI_1019_Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
           int timeToConvert = InputSystem.ReadIntNumber();

           TimeConverter.ConvertSecondsToTimerView(timeToConvert);

           Console.ReadKey();
        }
    }
}
