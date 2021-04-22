using System;
using System.Collections.Generic;
using Input;
using Input.Numbers;
using Math;
using Math.NumberCheck;

namespace URI_1035_Selection_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> results = new List<bool>();

            string lineRead = InputSystem.ReadLine();
            NumberReader numbersRead = new NumberReader(lineRead);

            int num_A = numbersRead.Read_A();
            int num_B = numbersRead.Read_B();
            int num_C = numbersRead.Read_C();
            int num_D = numbersRead.Read_D();

            bool auxResult;

            auxResult = NumberChecker.IsNumberGreaterThanOtherNumber(num_B, num_C); 
            results.Add(auxResult);

            auxResult = NumberChecker.IsNumberGreaterThanOtherNumber(num_D, num_A); 
            results.Add(auxResult);

            int sumC_D = MathOperations.Sum(num_C, num_D);
            int sumA_B = MathOperations.Sum(num_A, num_B);
            auxResult = NumberChecker.IsNumberGreaterThanOtherNumber(sumC_D, sumA_B); 
            results.Add(auxResult);

            auxResult = NumberChecker.IsNumberPositive(num_C); 
            results.Add(auxResult);

            auxResult = NumberChecker.IsNumberPositive(num_D); 
            results.Add(auxResult);

            auxResult = NumberChecker.IsNumberEven(num_A); 
            results.Add(auxResult);

            CheckResults.CheckIfAllResultsAreTrue(results);

            Console.ReadKey();
        }
    }
}
