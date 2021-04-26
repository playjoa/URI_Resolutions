using System;

namespace Maths.Equations
{
    public class Bhaskara
    {
        private double value_A, value_B, value_C;

        public Bhaskara(double a, double b, double c)
        {
            value_A = a;
            value_B = b;
            value_C = c;
        }

        public void Calculate()
        {
            if (value_A == 0 || Delta_Value() < 0)
            {
                PrintInvalidResult();
                return;
            }

            PrintResult();
        }

        void PrintResult()
        {
            Console.WriteLine("R1 = " + Value_X1().ToString("0.00000"));
            Console.WriteLine("R2 = " + Value_X2().ToString("0.00000"));
        }

        void PrintInvalidResult()
        {
            Console.WriteLine("Impossivel calcular");
        }

        double Delta_Value()
        {
            double resultado = 0;

            resultado = (value_B * value_B) - 4 * value_A * value_C;

            return resultado;
        }

        double SquareRootOfDelta()
        {
            return Math.Sqrt(Delta_Value());
        }

        double Value_X1()
        {
            double resultado = 0;

            resultado = (-value_B + SquareRootOfDelta()) / (2 * value_A);

            return resultado;
        }

        double Value_X2()
        {
            double resultado = 0;

            resultado = (-value_B - SquareRootOfDelta()) / (2 * value_A);

            return resultado;
        }
    }
}