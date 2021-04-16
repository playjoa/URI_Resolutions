using System;
using Inputs;

namespace URI_1016_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carroMaisLento = new Car(60);
            Car carroMaisRapido = new Car(90);

            DistanceBetween2CarsCalculator calculadorDistancia = new DistanceBetween2CarsCalculator(carroMaisRapido, carroMaisLento);

            int distanciaParaAtingir = InputSystem.ReadIntNumber();

            calculadorDistancia.CalcularTempoUltrapassagem(distanciaParaAtingir);

            Console.ReadKey();        
        }
    }
}
