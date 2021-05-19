using System;
using Intervals.Manager;
using Intervals;
using Inputs;

namespace URI_1037_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            IntervalsHolder allIntervals = IntervalHolderCreator();

            double numberToCheck = InputSystem.ReadDoubleNumber();

            allIntervals.CheckWhatIntervalNumberBelongs(numberToCheck);

            Console.ReadKey();
        }

        static IntervalsHolder IntervalHolderCreator()
        {
            IntervalsHolder creator = new IntervalsHolder();

            Interval tempInterval = new IntervalGreaterThan(0, 25, "[0,25]");
            creator.AddInterval(tempInterval);

            tempInterval = new IntervalGreaterEqualThan(25, 50, "(25,50]");
            creator.AddInterval(tempInterval);

            tempInterval = new IntervalGreaterEqualThan(50, 75, "(50,75]");
            creator.AddInterval(tempInterval);

            tempInterval = new IntervalGreaterEqualThan(75, 100, "(75,100]");
            creator.AddInterval(tempInterval);

            return creator;
        }
    }
}
