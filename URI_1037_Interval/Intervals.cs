namespace Intervals
{
    public class IntervalGreaterEqualThan : Interval
    {
        private double minValue, maxValue;
        string intervalName;

        public IntervalGreaterEqualThan(double minValue, double maxValue, string intervalName)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.intervalName = intervalName;
        }

        public string IntervalName => intervalName;

        public bool ThisNumberBelongsInInterval(double number)
        {
            if (number >= minValue && number <= maxValue)
                return true;

            return false;
        }
    }

    public class IntervalGreaterThan : Interval
    {
        private double minValue, maxValue;
        string intervalName;

        public IntervalGreaterThan(double minValue, double maxValue, string intervalName)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.intervalName = intervalName;
        }

        public string IntervalName => intervalName;

        public bool ThisNumberBelongsInInterval(double number)
        {
            if (number > minValue && number <= maxValue)
                return true;

            return false;
        }
    }

    public interface Interval
    {
        bool ThisNumberBelongsInInterval(double number);
        string IntervalName { get; }
    }
}