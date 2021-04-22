using System;
using System.Collections.Generic;

namespace Math.NumberCheck
{
    public static class CheckResults
    {
        public static void CheckIfAllResultsAreTrue(List<bool> results)
        {
            bool result = true;

            foreach (bool value in results)
            {
                if (!value)
                {
                    result = false;
                    break;
                }

            }

            if (result)
                PrintValidNumbers();
            else
                PrintInvalidNumbers();
        }

        static void PrintInvalidNumbers()
        {
            Console.WriteLine("Valores nao aceitos");
        }

        static void PrintValidNumbers()
        {
            Console.WriteLine("Valores aceitos");
        }
    }
}