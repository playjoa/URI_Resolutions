using System;

namespace Navegation
{
    public class ComputadorDeBordo
    {
        private int consumo_KM_L;
        private Trip tripAtual;

        public ComputadorDeBordo(int consumo_KM_L)
        {
            this.consumo_KM_L = consumo_KM_L;
        }

        public void CriarTrip(int horas_Trip, int velocidadeMedia_Trip)
        {
            tripAtual = new Trip(horas_Trip, velocidadeMedia_Trip);
        }

        public void DebugAutonomia()
        {
            Console.WriteLine(AutonomiaTanque().ToString("0.000"));
        }

        double AutonomiaTanque()
        {
            return tripAtual.DistanciaTrip() / consumo_KM_L;
        }
    }
}