using System;

namespace Input
{
    public static class InputSystem
    {
        public static int ReadIntNumber()
        {
            string inputString = Console.ReadLine();
            return Convert.ToInt32(inputString);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static double ReadDoubleNumber()
        {
            string inputString = Console.ReadLine();
            return double.Parse(inputString);
        }
    }
}