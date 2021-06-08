using System;

namespace Inputs
{
    public static class InputSystem
    {
        public static int ReadIntNumber() => Convert.ToInt32(LineRead);

        public static string ReadLine => Console.ReadLine();

        public static double ReadDoubleNumber() => double.Parse(LineRead);

        static string LineRead => Console.ReadLine();
    }
}