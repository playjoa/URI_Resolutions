using System;
using Inputs;
using Navegation;

namespace URI_1017_Fuel_Spent
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputadorDeBordo computadorAtual = new ComputadorDeBordo(12);

            int horasTrip, veloMediaTrip;

            horasTrip = InputSystem.ReadIntNumber();
            veloMediaTrip = InputSystem.ReadIntNumber();

            computadorAtual.CriarTrip(horasTrip, veloMediaTrip);

            computadorAtual.DebugAutonomia();

            Console.ReadKey();
        }
    }
}
