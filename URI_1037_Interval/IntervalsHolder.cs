using System;
using System.Collections.Generic;

namespace Intervals.Manager
{
    public class IntervalsHolder
    {
        private List<Interval> intervalsList;

        public IntervalsHolder()
        {
            intervalsList = new List<Interval>();
        }

        public void AddInterval(Interval newInterval)
        {
            intervalsList.Add(newInterval);
        }

        public void CheckWhatIntervalNumberBelongs(double number)
        {
            Interval intervalFound = IntervalInThatNumberBelongs(number);

            PrintInterval(intervalFound);
        }

        Interval IntervalInThatNumberBelongs(double number)
        {
            foreach(Interval currentInterval in intervalsList)
            {
                if(currentInterval.ThisNumberBelongsInInterval(number))
                    return currentInterval;
            }
            return null;
        }

        void PrintInterval(Interval intervalToPrint)
        {
            if (intervalsList.Count == 0 || intervalToPrint == null)
            {
                Console.WriteLine("Fora de intervalo");
                return;
            }

            Console.WriteLine("Intervalo " + intervalToPrint.IntervalName);
        }
    }
}