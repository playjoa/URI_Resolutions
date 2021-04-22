using System;

namespace Math.NumberCheck
{
    public static class NumberChecker
    {
        public static bool IsNumberGreaterThanOtherNumber(int numA, int numB)
        {
            if (numA > numB)
                return true;

            return false;
        }

        public static bool IsNumberPositive(int number)
        {
            if (number >= 0)
                return true;

            return false;
        }

        public static bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;

            return false;
        }
    }
}