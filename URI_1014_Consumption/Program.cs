using System;
using Inputs;

namespace URI_1014_Consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaPercorrida;
            double gasolinaGasta;

            distanciaPercorrida = InputSystem.ReadIntNumber();
            gasolinaGasta = InputSystem.ReadDoubleNumber();

            ComputadorDeBordo computadorAtual = new ComputadorDeBordo(distanciaPercorrida, gasolinaGasta);

            computadorAtual.DebugConsumo();

            Console.ReadKey();
        }
    }
}
