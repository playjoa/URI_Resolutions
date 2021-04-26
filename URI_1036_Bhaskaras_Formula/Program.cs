using System;
using Input;
using Input.NumberReader;
using Maths.Equations;

namespace URI_1036_Bhaskaras_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineRead = InputSystem.ReadLine();

            NumberReader numbersRead = new NumberReader(lineRead);

            double value_A = numbersRead.Read_A();
            double value_B = numbersRead.Read_B();
            double value_C = numbersRead.Read_C();

            Bhaskara formulaBhaskara = new Bhaskara(value_A, value_B, value_C);

            formulaBhaskara.Calculate();

            Console.ReadKey();
        }
    }
}
